using Newtonsoft.Json;
using PTMB_Systatus_API.Data.DataSet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Data.DAO
{
    public class SqlDaoData
    {  
        public string ConvertSQLToData(SqlQueryAction sqlQueryAction,DataTable dt)
        {
            switch (sqlQueryAction)
            {
                case SqlQueryAction.ADD_NEWSUBBSYS_STATUSINFO:
                    break;
                case SqlQueryAction.GET_SYSINFO:
                    return GET_SYSINFO(dt);

                case SqlQueryAction.REGISTER_SYSTATUS_INFO:
                    break;
                case SqlQueryAction.GET_ALL_INFO:
                    return GET_ALL_INFO(dt);
                    
                case SqlQueryAction.GET_SPECIFIC_INFO:

                    List<SubSysStatusInfo> list_All_SubSysStatuisInfo = JsonConvert.DeserializeObject<List<SubSysStatusInfo>>(dt.Rows[0]["subsys_info"].ToString());
                    return JsonConvert.SerializeObject(list_All_SubSysStatuisInfo);

                case SqlQueryAction.GET_CURRENT_INFO:
                    return GET_CURRENT_INFO(dt);
                case SqlQueryAction.GET_EXCUTE_TIME_ALL:
                    break;
                case SqlQueryAction.GET_EXCUTE_TIME_SYSNO:
                    break;
                default:
                    break;
            }
            return ErrorMessage.getInstance().ErrorMsg;

        }

        #region SQL_DAO_LOGIC
        public string GET_SYSINFO(DataTable dt)
        {
            List<SysStatusInfo> list_SysStatuisInfo = new List<SysStatusInfo>();

            foreach (DataRow row in dt.Rows)
            {
                /// Init 
                SysStatusInfo SysStatusInfo = new SysStatusInfo();
                SysStatusInfo.subsys_info = new List<SubSysStatusInfo>();

                /// Set Data
                SysStatusInfo.C_Keys = row["c_keys"].ToString();
                SysStatusInfo.Company = (Company)Enum.Parse(typeof(Company), row["company"].ToString());
                SysStatusInfo.SysNo = (DefaultSystemNo)Enum.Parse(typeof(DefaultSystemNo), row["sys_no"].ToString());
                SysStatusInfo.SysStatus = (SysStatus)Enum.Parse(typeof(SysStatus), row["sys_status"].ToString());
                SysStatusInfo.UpdateTime = row["updateTime"].ToString();
                SysStatusInfo.subsys_info = JsonConvert.DeserializeObject<List<SubSysStatusInfo>>(row["subsys_info"].ToString());

                /// Add To List
                list_SysStatuisInfo.Add(SysStatusInfo);
            }
            // Return Result
            return JsonConvert.SerializeObject(list_SysStatuisInfo);
        }
        public string GET_ALL_INFO(DataTable dt)
        {
            List<SysStatusInfo> list_All_SysStatuisInfo = new List<SysStatusInfo>();

            foreach (DataRow row in dt.Rows)
            {
                /// Init 
                SysStatusInfo SysStatusInfo = new SysStatusInfo();
                SysStatusInfo.subsys_info = new List<SubSysStatusInfo>();

                /// Set Data
                SysStatusInfo.C_Keys = row["c_keys"].ToString();
                SysStatusInfo.Company = (Company)Enum.Parse(typeof(Company), row["company"].ToString());
                SysStatusInfo.SysNo = (DefaultSystemNo)Enum.Parse(typeof(DefaultSystemNo), row["sys_no"].ToString());
                SysStatusInfo.SysStatus = (SysStatus)Enum.Parse(typeof(SysStatus), row["sys_status"].ToString());
                SysStatusInfo.UpdateTime = row["updateTime"].ToString();
                SysStatusInfo.subsys_info = JsonConvert.DeserializeObject<List<SubSysStatusInfo>>(row["subsys_info"].ToString());

                /// Add To List
                list_All_SysStatuisInfo.Add(SysStatusInfo);
            }
            return JsonConvert.SerializeObject(list_All_SysStatuisInfo);
        }

        public string GET_CURRENT_INFO(DataTable dt)
        {
            SysStatusInfo Current_SysStatusInfo = new SysStatusInfo();

            Current_SysStatusInfo.C_Keys = dt.Rows[0]["c_keys"].ToString();
            Current_SysStatusInfo.Company = (Company)Enum.Parse(typeof(Company), dt.Rows[0]["company"].ToString());
            Current_SysStatusInfo.SysNo = (DefaultSystemNo)Enum.Parse(typeof(DefaultSystemNo), dt.Rows[0]["sys_no"].ToString());
            Current_SysStatusInfo.UpdateTime = dt.Rows[0]["updateTime"].ToString();
            Current_SysStatusInfo.subsys_info = JsonConvert.DeserializeObject<List<SubSysStatusInfo>>(dt.Rows[0]["subsys_info"].ToString());
            Current_SysStatusInfo.SysStatus = (SysStatus)Enum.Parse(typeof(SysStatus),dt.Rows[0]["sys_status"].ToString());
            Current_SysStatusInfo.subsys_info.Sort((x, y) => -x.UpdateTime.CompareTo(y.UpdateTime));  
            return JsonConvert.SerializeObject(Current_SysStatusInfo);
        }



        #endregion

        public static SqlDaoData Instance = new SqlDaoData();
        public static SqlDaoData getInstance()
        {
            return Instance;
        }
        private SqlDaoData()
        {

        }
    }

    public class DaoData
    {
        public List<SysStatusInfo> GetAllInformation(string json_data)
        {
            return JsonConvert.DeserializeObject<List<SysStatusInfo>>(json_data);
        }
        public List<SubSysStatusInfo> GetSpecificInformation(string json_data)
        {
            List<SubSysStatusInfo> list_SubSysStatusInfo = JsonConvert.DeserializeObject<List<SubSysStatusInfo>>(json_data);
            list_SubSysStatusInfo.Sort((x, y) => -x.UpdateTime.CompareTo(y.UpdateTime));
            return list_SubSysStatusInfo;
        }
        public ExcuteResultInfo GetOnlyExcuteSqlExcuteResult(ExcuteResultSql OnlyExcuteSql)
        {
            return JsonConvert.DeserializeObject<ExcuteResultInfo>(JsonConvert.SerializeObject(OnlyExcuteSql));
        }
        public ExcuteOverCurrentSubAndSubSysInfo GetExcuteOverCurrentSubAndSubSysInfoResult(string json_data)
        {
            SysStatusInfo sysStatusInfo = JsonConvert.DeserializeObject<SysStatusInfo>(json_data);
            ExcuteOverCurrentSubAndSubSysInfo excuteOverCurrentSubAndSubSysInfo = JsonConvert.DeserializeObject<ExcuteOverCurrentSubAndSubSysInfo>(json_data);
            excuteOverCurrentSubAndSubSysInfo.SubSysNo = sysStatusInfo.subsys_info[0].SubSysNo;
            excuteOverCurrentSubAndSubSysInfo.SubsysStatus = sysStatusInfo.subsys_info[0].SubsysStatus.ToString();
            excuteOverCurrentSubAndSubSysInfo.Operator = sysStatusInfo.subsys_info[0].Operator.ToString();
            excuteOverCurrentSubAndSubSysInfo.Remark = sysStatusInfo.subsys_info[0].Remark;
            excuteOverCurrentSubAndSubSysInfo.ExtendsInfo = sysStatusInfo.subsys_info[0].ExtendsInfo;
            return excuteOverCurrentSubAndSubSysInfo;
        }

        public static DaoData Instance = new DaoData();
        public static DaoData getInstance()
        {
            return Instance;
        }
        private DaoData()
        {

        }
    }

}
