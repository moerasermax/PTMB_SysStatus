using Newtonsoft.Json;
using PTMB_Systatus_API.Data.DAO;
using PTMB_Systatus_API.Data.DataSet;
using PTMB_Systatus_API.Model.Implement.SQL;
using PTMB_Systatus_API.Model.Interface;
using PTMB_Systatus_API.Model.Interface.SysStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTMB_Systatus_API.Model.Implement.Systatus
{
    public class SysStatus_Controller : SysStatus_GetData
    {
        

        public static SysStatus_Controller Instance = new SysStatus_Controller();
        public static SysStatus_Controller getInstance()
        {
            return Instance;
        }
        private SysStatus_Controller()
        {

        }

    }


    public class SysStatus_GetData : SysStatus_NewData, ISyststus_GetData
    {
        public List<SysStatusInfo> GetAllInformation(string C_Keys, Company Company)
        {
            SqlSysStatus_Controller sqlSysStatus_Controller = SqlSysStatus_Controller.getInstance();
            ExcuteResultSql result = sqlSysStatus_Controller.GetCkeysAllInfo(C_Keys, Company.ToString());
            FeedBackMsg = result.FeedBackMsg;
            isSuccess = result.isSuccess;

            if (result.isSuccess)
            {                
                return DaoData.getInstance().GetAllInformation(result.SqlExcuteResultJsonData);
            }
            else
            {
                ErrorMessage.getInstance().Show_Error(result);
                //throw new Exception(ErrorMessage.getInstance().ErrorMsg);
                return new List<SysStatusInfo>();
            }
        }

        public List<SubSysStatusInfo> GetSpecificInformation(string C_Keys, Company Company, string SubsysNo)
        {
            SqlSysStatus_Controller sqlSysStatus_Controller = SqlSysStatus_Controller.getInstance();
            ExcuteResultSql result = sqlSysStatus_Controller.GetCkeysAllInfo(C_Keys, Company.ToString(), SubsysNo);
            FeedBackMsg = result.FeedBackMsg;
            isSuccess = result.isSuccess;

            if (result.isSuccess)
            {
                return DaoData.getInstance().GetSpecificInformation(result.SqlExcuteResultJsonData);
            }
            else
            {
                ErrorMessage.getInstance().Show_Error(result);
                //throw new Exception(ErrorMessage.getInstance().ErrorMsg);
                return new List<SubSysStatusInfo>();
            }

        }
        public ExcuteOverCurrentSubAndSubSysInfo GetCurrentInfo(string C_Keys, Company Company)
        { 

            SqlSysStatus_Controller sqlSysStatus_Controller = SqlSysStatus_Controller.getInstance();
            ExcuteResultSql result = sqlSysStatus_Controller.GetCurrentInfo(C_Keys, Company.ToString());

            FeedBackMsg=result.FeedBackMsg;
            isSuccess=result.isSuccess;

            if (result.isSuccess)
            {
                return DaoData.getInstance().GetExcuteOverCurrentSubAndSubSysInfoResult(result.SqlExcuteResultJsonData);
            }
            else
            {
                ErrorMessage.getInstance().Show_Error(result);
                //throw new Exception(ErrorMessage.getInstance().ErrorMsg);
                return new ExcuteOverCurrentSubAndSubSysInfo();
            }
            



        }

        public ExcuteOverCurrentSubSysInfo GetExcuteTime(string C_Keys, Company Company)
        {
            //// 取所有系統的子系統時間
            List<SysStatusInfo> sysStatusInfos = GetAllInformation(C_Keys, Company);
            List<SubSysStatusInfo> AllSubSysStatusInfo = new List<SubSysStatusInfo>();
            foreach (SysStatusInfo item in sysStatusInfos)
            {
                foreach (SubSysStatusInfo subsysinfo in item.subsys_info)
                {
                    AllSubSysStatusInfo.Add(subsysinfo);
                }
            }
            AllSubSysStatusInfo.Sort((x,y)=> x.UpdateTime.CompareTo(y.UpdateTime));



            DateTime Start = ConvertoSeconds(AllSubSysStatusInfo[0].UpdateTime);
            DateTime End = ConvertoSeconds(AllSubSysStatusInfo[AllSubSysStatusInfo.Count-1].UpdateTime);
            
            ExcuteOverCurrentSubSysInfo excuteOverCurrentSubSysInfo = new ExcuteOverCurrentSubSysInfo();
            excuteOverCurrentSubSysInfo.SysNo = AllSubSysStatusInfo[AllSubSysStatusInfo.Count - 1].SysNo.ToString();
            excuteOverCurrentSubSysInfo.SubSysNo = AllSubSysStatusInfo[AllSubSysStatusInfo.Count - 1].SubSysNo.ToString();
            excuteOverCurrentSubSysInfo.Excute_TotalTime =  End.Subtract(Start); //子系統流程執行時間(目前子系統的最後流程狀態時間-入口點時間)
            excuteOverCurrentSubSysInfo.Process_TotalTime = DateTime.Now.Subtract(Start); //總執行時間(當前時間-入口點)

            return excuteOverCurrentSubSysInfo;
        }

        public ExcuteOverCurrentSubSysInfo GetSysNoExcuteTime(string C_Keys, Company Company, DefaultSystemNo SysNo)
        {
            List<SysStatusInfo> preDeleteList = GetAllInformation(C_Keys, Company);
            List<SysStatusInfo> sysStatusInfos = GetAllInformation(C_Keys, Company);

            foreach (SysStatusInfo item in sysStatusInfos)
            {
                if (item.SysNo != SysNo)
                {
                        int index = sysStatusInfos.IndexOf(item);
                        preDeleteList.RemoveAt(index);
                }
            }
            sysStatusInfos= preDeleteList;
            DateTime Start = ConvertoSeconds(sysStatusInfos[0].subsys_info[0].UpdateTime);
            DateTime End = ConvertoSeconds(sysStatusInfos[sysStatusInfos.Count - 1].subsys_info[sysStatusInfos[sysStatusInfos.Count - 1].subsys_info.Count - 1].UpdateTime);

            ExcuteOverCurrentSubSysInfo excuteOverCurrentSubSysInfo = new ExcuteOverCurrentSubSysInfo();
            excuteOverCurrentSubSysInfo.SysNo = sysStatusInfos[sysStatusInfos.Count - 1].SysNo.ToString();
            excuteOverCurrentSubSysInfo.SubSysNo = sysStatusInfos[sysStatusInfos.Count - 1].subsys_info[sysStatusInfos[sysStatusInfos.Count - 1].subsys_info.Count - 1].SubSysNo;
            excuteOverCurrentSubSysInfo.Excute_TotalTime = End.Subtract(Start); //子系統流程執行時間(目前子系統的最後流程狀態時間-入口點時間)
            excuteOverCurrentSubSysInfo.Process_TotalTime = DateTime.Now.Subtract(Start); //總執行時間(當前時間-入口點)

            return excuteOverCurrentSubSysInfo;
        }



        public DateTime ConvertoSeconds(string datetime)
        {
            //2022 - 12 - 20 - 13:15:48
            string[] Date = datetime.Split('-');
            string[] Time = Date[3].Split(':');

            DateTime origin = new DateTime(int.Parse(Date[0]), int.Parse(Date[1]), int.Parse(Date[2]), int.Parse(Time[0]), int.Parse(Time[1]), int.Parse(Time[2]), DateTimeKind.Utc);
            return origin;
        }


    }

    public class SysStatus_NewData : ISysStatus_NewData
    {
        public string FeedBackMsg { get; set; }
        public bool isSuccess { get; set; }
        public ExcuteResultInfo CheckIn(DataSetCheckInData CheckInData)
        {
            foreach (SubSysStatusInfo item in CheckInData.subsys_info)
            {
                item.UpdateTime = DateTime.Parse(item.UpdateTime).ToString("yyyy-MM-dd-HH:mm:ss");
            }
            
            SqlSysStatus_Controller sqlSysStatus_Controller = SqlSysStatus_Controller.getInstance();
            ExcuteResultSql result = sqlSysStatus_Controller.CheckIn(CheckInData);
            FeedBackMsg = result.FeedBackMsg;
            isSuccess = result.isSuccess;
            if (result.isSuccess)
            {
                return DaoData.getInstance().GetOnlyExcuteSqlExcuteResult(result);
            }
            else
            {
                ErrorMessage.getInstance().Show_Error(result);
                //throw new Exception(ErrorMessage.getInstance().ErrorMsg);
                return new ExcuteResultInfo();
            }
        }

    }

}
