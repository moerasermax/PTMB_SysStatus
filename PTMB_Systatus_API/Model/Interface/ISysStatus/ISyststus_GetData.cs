using PTMB_Systatus_API.Data.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Interface.SysStatus
{
    public interface ISyststus_GetData
    {
        List<SysStatusInfo> GetAllInformation(string C_Keys,Company Company); /// 獲取此 C_Keys 的所有狀態資訊
        List<SubSysStatusInfo> GetSpecificInformation(string C_Keys, Company Company, String SubsysNo); /// 獲取此 C_Keys 的所有狀態資訊
        ExcuteOverCurrentSubAndSubSysInfo GetCurrentInfo(string C_Keys,Company Company); /// 取得此 C_Keys 執行到現在的系統以及子系統
        
        /// GetExcuteTime --->  取得執行時間
        ExcuteOverCurrentSubSysInfo GetExcuteTime(string C_Keys, Company Company); /// 取得此 C_Keys 到目前流程的時間；
        ///DateTime GetExcuteTime(string C_Keys, Company Company, string SysNo); /// 取得此 C_Keys 在此系統編號中花了多少時間



    }
}
