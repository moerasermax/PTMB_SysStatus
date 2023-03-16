using Newtonsoft.Json;
using PTMB_Systatus_API.Data.DataSet;
using PTMB_Systatus_API.Model.Implement.SQL;
using PTMB_Systatus_API.Model.Interface;
using PTMB_Systatus_API.Model.Interface.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Abstract.SQL
{
    public class SqlSysStatus_Main : SqlSysStatus_GetData, ISqlSysStatus_NewAndUpdateData
    {
        SqlSysStatus_Common sqlSysStatus_Common = SqlSysStatus_Common.getInstance();
        DevEnviroment dev = DevEnviroment.SysStatus_Release;

        /// <summary>
        /// 進行打卡
        /// </summary>
        /// <param name="CheckInData">各子系統打卡系統</param>
        /// <returns></returns>
        /// <exception cref="Exception">錯誤回拋訊息</exception>
        public ExcuteResultSql CheckIn(DataSetCheckInData CheckInData)
        {
            if (CompareData_integrity(CheckInData))
            {
                string Value = string.Format("{0},,,,,{1},,,,,{2}", CheckInData.C_Keys, CheckInData.Company, CheckInData.SysNo);
                ExcuteResultSql excuteResultSql = new ExcuteResultSql();
                try
                {
                    /// <--之後可以包成 GetData的部分-->
                    SqlConnection conn = sqlSysStatus_Common.GetSqlConnection(dev);
                    SqlCommand cmd = sqlSysStatus_Common.GetSqlCommand(SqlQueryAction.GET_SYSINFO, conn);
                    cmd = sqlSysStatus_Common.SetParameter(SqlQueryAction.GET_SYSINFO, cmd, Value);
                    List<SysStatusInfo> SysNo_Data = JsonConvert.DeserializeObject<List<SysStatusInfo>>(sqlSysStatus_Common.Excute(SqlQueryCategory.GET, SqlQueryAction.GET_SYSINFO, conn, cmd).SqlExcuteResultJsonData); // 若Count>0 代表已經開始記錄了；若為 0 代表尚未開始記錄，必須先建立系統狀態資料
                    /// <!--之後可以包成 GetData的部分--!>

                    if (SysStatusInfoisExisting(SysNo_Data)) // 驗證是否具有此系統編號的資料
                    {
                        // 先將歷史紀錄轉為 List
                        List<SubSysStatusInfo> History_SubsysStatusInfo = SysNo_Data[0].subsys_info;
                        // 再將這次要加入的紀錄 Add進去
                        foreach (SubSysStatusInfo item in CheckInData.subsys_info)
                        {
                            History_SubsysStatusInfo.Add(item);
                        }
                        // 轉為 JSON 字串
                        string History_SubsysStatusInfo_Json = JsonConvert.SerializeObject(History_SubsysStatusInfo);

                        Value = String.Format("{0},,,,,{1},,,,,{2},,,,,{3},,,,,{4}", CheckInData.C_Keys, CheckInData.Company, CheckInData.SysNo, History_SubsysStatusInfo_Json, DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss"));
                        cmd = sqlSysStatus_Common.GetSqlCommand(SqlQueryAction.ADD_NEWSUBBSYS_STATUSINFO, conn);
                        cmd = sqlSysStatus_Common.SetParameter(SqlQueryAction.ADD_NEWSUBBSYS_STATUSINFO, cmd, Value);
                        sqlSysStatus_Common.Excute(SqlQueryCategory.Update, SqlQueryAction.ADD_NEWSUBBSYS_STATUSINFO, conn, cmd);
                    }
                    else
                    {
                        /// 註冊此 C_Keys 的子系統狀態
                        RegisterSysStatusInfo(conn, cmd, CheckInData, Value);
                    }
                    excuteResultSql.isSuccess = true;
                    excuteResultSql.FeedBackMsg = "執行成功";
                }
                catch (Exception ex)
                {
                    return Error_ExcuteResultSql(ex.Message.ToString());
                }
                return excuteResultSql;
            }
            else
            {
                return Error_ExcuteResultSql("請將資料填寫完整");
            }

        }


        /// <summary>
        /// 建立此 C_Key 的 子系統編號 註冊
        /// </summary>
        /// <param name="sqlActionCategory">SQL執行的分類</param>
        /// <param name="sqlQueryAction">SQL執行的動作'</param>
        /// <param name="Value">傳入的資料</param>
        /// <returns></returns>
        private ExcuteResultSql RegisterSysStatusInfo(SqlConnection conn, SqlCommand cmd, DataSetCheckInData CheckInData, string Value)
        {
            string History_SusysStatusInfo_Json = JsonConvert.SerializeObject(CheckInData.subsys_info);
            Value = String.Format("{0},,,,,{1},,,,,{2},,,,,{3},,,,,{4},,,,,{5}", CheckInData.C_Keys, CheckInData.Company, CheckInData.SysNo, CheckInData.SysStatus, DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss"), History_SusysStatusInfo_Json);
            cmd = sqlSysStatus_Common.GetSqlCommand(SqlQueryAction.REGISTER_SYSTATUS_INFO, conn);
            cmd = sqlSysStatus_Common.SetParameter(SqlQueryAction.REGISTER_SYSTATUS_INFO, cmd, Value);
            return sqlSysStatus_Common.Excute(SqlQueryCategory.Insert, SqlQueryAction.REGISTER_SYSTATUS_INFO, conn, cmd);
        }

        /// <summary>
        /// 檢測此C_Keys 的 子系統編號 在資料庫是否已經存在
        /// </summary>
        /// <param name="SysNo_Data"></param>
        /// <returns></returns>
        bool SysStatusInfoisExisting(List<SysStatusInfo> SysNo_Data)
        {
            if (SysNo_Data.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 驗證資料的完整性
        /// </summary>
        /// <param name="CheckInData"></param>
        /// <returns></returns>
        private bool CompareData_integrity(DataSetCheckInData CheckInData)
        {
            if ((CheckInData.C_Keys != null) && (CheckInData.C_Keys != ""))
            {
                foreach (SubSysStatusInfo subsysinfo in CheckInData.subsys_info)
                {
                    if ((subsysinfo.SysNo == null) || (subsysinfo.Operator == null) && (subsysinfo.Operator == ""))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }




    }


    public class SqlSysStatus_GetData : ISqlSysStatus_GetData
    {
        SqlSysStatus_Common sqlSysStatus_Common = SqlSysStatus_Common.getInstance();
        DevEnviroment dev = DevEnviroment.SysStatus_Release;


        public ExcuteResultSql GetCkeysAllInfo(string C_Keys, string Company)
        {
            if ((C_Keys != null) && (C_Keys != ""))
            {
                try
                {
                    string Value = string.Format("{0},,,,,{1}", C_Keys, Company);
                    SqlConnection conn = sqlSysStatus_Common.GetSqlConnection(dev);
                    SqlCommand cmd = sqlSysStatus_Common.GetSqlCommand(SqlQueryAction.GET_ALL_INFO, conn);
                    cmd = sqlSysStatus_Common.SetParameter(SqlQueryAction.GET_ALL_INFO, cmd, Value);
                    return sqlSysStatus_Common.Excute(SqlQueryCategory.GET, SqlQueryAction.GET_ALL_INFO, conn, cmd);
                }
                catch (Exception ex)
                {

                    return Error_ExcuteResultSql(ex.Message);
                }
            }
            else
            {
                return Error_ExcuteResultSql("請將資料填寫完整");
            }
        }

        public ExcuteResultSql GetCkeysAllInfo(string C_Keys, string Company, string SubSysNo)
        {
            if (((C_Keys != null) && (C_Keys != "")) && (SubSysNo != null) && (SubSysNo != "") && (Company != null) && (Company != ""))
            {
                try
                {
                    string Value = string.Format("{0},,,,,{1},,,,,{2}", C_Keys, Company, SubSysNo);
                    SqlConnection conn = sqlSysStatus_Common.GetSqlConnection(dev);
                    SqlCommand cmd = sqlSysStatus_Common.GetSqlCommand(SqlQueryAction.GET_SPECIFIC_INFO, conn);
                    cmd = sqlSysStatus_Common.SetParameter(SqlQueryAction.GET_SPECIFIC_INFO, cmd, Value);
                    return sqlSysStatus_Common.Excute(SqlQueryCategory.GET, SqlQueryAction.GET_SPECIFIC_INFO, conn, cmd);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("沒有資料列"))
                    {
                        return Error_ExcuteResultSql("查無資料，請重新確認");
                    }
                    return Error_ExcuteResultSql(ex.Message);
                }
            }
            else
            {
                return Error_ExcuteResultSql("請將資料填寫完整");
            }
        }

        public ExcuteResultSql GetCurrentInfo(string C_Keys, string Company)
        {
            if ((C_Keys != null) && (C_Keys != ""))
            {
                try
                {
                    string Value = string.Format("{0},,,,,{1}", C_Keys, Company);
                    SqlConnection conn = sqlSysStatus_Common.GetSqlConnection(dev);
                    SqlCommand cmd = sqlSysStatus_Common.GetSqlCommand(SqlQueryAction.GET_CURRENT_INFO, conn);
                    cmd = sqlSysStatus_Common.SetParameter(SqlQueryAction.GET_CURRENT_INFO, cmd, Value);
                    return sqlSysStatus_Common.Excute(SqlQueryCategory.GET, SqlQueryAction.GET_CURRENT_INFO, conn, cmd);
                }
                catch (Exception ex)
                {

                    return Error_ExcuteResultSql(ex.Message);
                }
            }
            else
            {
                return Error_ExcuteResultSql("請將資料填寫完整");
            }
        }


        public ExcuteResultSql Error_ExcuteResultSql(string FailReason)
        {
            ExcuteResultSql excuteResultSql = new ExcuteResultSql();
            excuteResultSql.isSuccess = false;
            excuteResultSql.FeedBackMsg = FailReason;
            excuteResultSql.FailReason = ErrorMessage.getInstance().ErrorMsg;
            return excuteResultSql;
        }
    }
}

