using PTMB_Systatus_API.Data.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Interface
{
    public interface ISqlSysStatus_NewAndUpdateData
    {

        #region 新增資料/狀態
        ExcuteResultSql CheckIn(DataSetCheckInData CheckInData); // ActionCategory: Update
        //ExcuteResultSql RegisterSysStatusInfo(SqlQueryCategory sqlActionCategory, SqlQueryAction sqlQueryAction, String Value); // ActionCategory: Insert
        //bool SysStatusInfoisExisting(List<SysStatusInfo> SysNo_Data); // ActionCategory: Get
        #endregion
    }







}
