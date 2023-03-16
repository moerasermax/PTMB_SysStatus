using PTMB_Systatus_API.Data.DataSet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Model.Interface.SQL
{
    public interface ISqlSysStatus_Common
    {
        SqlConnection GetSqlConnection(DevEnviroment DevEnviroment);
        SqlCommand GetSqlCommand(SqlQueryAction SqlAction, SqlConnection conn);
        SqlCommand SetParameter(SqlQueryAction SqlAction, SqlCommand SqlCommand, String Value);
        ExcuteResultSql Excute(SqlQueryCategory SqlQueryCategory, SqlQueryAction SqlQueryAction, SqlConnection conn, SqlCommand SqlCommand);
    }
}
