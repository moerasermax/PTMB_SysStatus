using PTMB_Systatus_API.Data.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Interface
{
    public interface ISysStatus_NewData
    {
        ExcuteResultInfo CheckIn(DataSetCheckInData CheckInData); /// 將資料Update進DB ---> 換言之將目前的資訊流打卡進DB
        //ExcuteResultInfo AddNewSubSysStatusInfo(string C_Keys, CompanyEnum Company, string SysNo, string SubSysNo ,string Operator, SubSysStatusEnum SubSysStatus);
        //ExcuteResultInfo RegisterSysStatusInfo(string C_Keys, Company Company, String SysNo);/// 若沒有此單的系統編號資料才執行


    }
}
