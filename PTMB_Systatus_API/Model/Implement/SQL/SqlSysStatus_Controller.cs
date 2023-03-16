using PTMB_Systatus_API.Model.Abstract.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Implement.SQL
{
    public class SqlSysStatus_Controller : SqlSysStatus_Main
    {
        public static SqlSysStatus_Controller Instance = new SqlSysStatus_Controller();
        public static SqlSysStatus_Controller getInstance()
        {
            return Instance;
        }
        private SqlSysStatus_Controller()
        {

        }
    }


}
