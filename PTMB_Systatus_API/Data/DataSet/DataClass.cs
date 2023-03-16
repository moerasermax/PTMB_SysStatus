using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTMB_Systatus_API.Data.DataSet
{
    #region Error Message
    public class ErrorMessage
    {
        public string ErrorMsg = "發生未知的錯誤，請檢查輸入資料，若無法正常排除，請聯絡【研發中心-郁宸】。";

        public void Show_Error(ExcuteResultSql result)
        {
            MessageBox.Show(String.Format("執行結果：{0} \r\n回饋訊息：{1} \r\n錯誤訊息：{2}", result.isSuccess.ToString(), result.FeedBackMsg, result.FailReason));
        }

        public static ErrorMessage Instance = new ErrorMessage();
        public static ErrorMessage getInstance()
        {
            return Instance;
        }
        private ErrorMessage()
        {

        }

    }
    #endregion

    #region Insert, Update
    public class SysStatusInfo
    {
        public string C_Keys { get; set; }
        public Company Company { get; set; }
        public DefaultSystemNo SysNo { get; set; }
        public SysStatus SysStatus { get; set; }
        public string UpdateTime { get; set; }
        public List<SubSysStatusInfo> subsys_info { get; set; }
    }

    public class SubSysStatusInfo
    {
        public DefaultSystemNo SysNo { get; set; }   
        public string SubSysNo { get; set; }
        public string Operator { get; set; }
        public string UpdateTime { get; set; }
        public SubSysStatus SubsysStatus { get; set; }
        public string Remark { get; set; }
        public ExtendsData ExtendsInfo { get; set; }

    }
    public class DataSetCheckInData
    {
        public string C_Keys { get; set; }
        public string Company { get; set; }
        public DefaultSystemNo SysNo { get; set; }
        public SysStatus SysStatus { get; set; }
        public List<SubSysStatusInfo> subsys_info { get; set; }
    }


    public class ExtendsData
    {
        public string Extend_Data { get; set; }
    }



    #endregion

    #region Info
    public class ExcuteOverCurrentSubSysInfo
    {
        public string SysNo { get; set; }
        public string SubSysNo { get; set; }
        public TimeSpan Excute_TotalTime { get; set; }
        public TimeSpan Process_TotalTime { get; set; }
    }

    public class ExcuteOverCurrentSubAndSubSysInfo
    {
        public string SysNo { get; set; }
        public string SubSysNo { get; set; }
        public string Operator { get; set; }
        public string UpdateTime { get; set; }
        public string SubsysStatus { get; set; }
        public string Remark { get; set; }
        public ExtendsData ExtendsInfo { get; set; }

    }



    #endregion

    #region SysStatusSystemEnum
    public enum SysStatus
    {
        Ing,
        Done
    }

    public enum SubSysStatus
    {
        ing,
        Done
    }

    public enum Company
    {
        LOANIT,
        PTMB
    }

    #endregion

    #region SqlEnum
    public enum SqlQueryCategory
    {
        Insert,
        Update,
        GET
    }

    public enum SqlQueryAction
    {
        ADD_NEWSUBBSYS_STATUSINFO, // 添加新的單號處理狀態
        GET_SYSINFO,            // 判斷是否存在指定的系統狀態資料
        REGISTER_SYSTATUS_INFO, // 添加新的單號處理資料
        GET_ALL_INFO,
        GET_SPECIFIC_INFO,
        GET_CURRENT_INFO,
        GET_EXCUTE_TIME_ALL,
        GET_EXCUTE_TIME_SYSNO,



    }


    public enum DefaultSystemNo
    {
        LY001, LY002, LY003, LY004, LY005, LY006, LY007, LY008, LY009, LY010, LY011,
        LF001, LF002, LF003, LF004, LF005, LF006, LF007, LF008, LF009, 
        LS001, LS002, LS003, LS004, LS005,
        CH001, CH002, CH003, 
        PF001, PF002, PF003
    }

    #endregion

    #region DevEnviromentEnum
    public enum DevEnviroment
    {
        SysStatus_Release,
        SysStatus_Test
    }
    #endregion
}
