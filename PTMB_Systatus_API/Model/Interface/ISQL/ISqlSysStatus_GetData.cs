using PTMB_Systatus_API.Data.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Interface.SQL
{
    public interface ISqlSysStatus_GetData
    {
        #region 取得狀態資訊

        ExcuteResultSql GetCkeysAllInfo(string C_Keys, string Company);
        ExcuteResultSql GetCkeysAllInfo(string C_Keys, string Company , string SubSysNo);




        #endregion
    }
}
