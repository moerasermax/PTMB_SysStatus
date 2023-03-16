using PTMB_Systatus_API.Data.DataSet;
using PTMB_Systatus_API.Model.Interface.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using PTMB_Systatus_API.Data.DAO;

namespace PTMB_Systatus_API.Model.Implement.SQL
{
    public class SqlSysStatus_Common : ISqlSysStatus_Common
    {
        public static SqlSysStatus_Common Instance = new SqlSysStatus_Common();
        public static SqlSysStatus_Common getInstance()
        {
            return Instance;
        }
        private SqlSysStatus_Common()
        {

        }

        public SqlConnection GetSqlConnection(DevEnviroment DevEnviroment)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings[DevEnviroment.ToString()].ConnectionString);

            switch (DevEnviroment)
            {
                case DevEnviroment.SysStatus_Release:
                    sqlConnectionStringBuilder.UserID = Decryption(sqlConnectionStringBuilder.UserID);
                    sqlConnectionStringBuilder.Password = Decryption(sqlConnectionStringBuilder.Password);
                    break;
                case DevEnviroment.SysStatus_Test:
                    sqlConnectionStringBuilder.UserID = Decryption(sqlConnectionStringBuilder.UserID);
                    sqlConnectionStringBuilder.Password = Decryption(sqlConnectionStringBuilder.Password);
                    break;
                default:
                    break;
            }
            SqlConnection conn = new SqlConnection(sqlConnectionStringBuilder.ToString());

            return conn;
        }
        public SqlCommand GetSqlCommand(SqlQueryAction SqlAction, SqlConnection conn)
        {
            string cmd_str = "";
            switch (SqlAction)
            {
                case SqlQueryAction.ADD_NEWSUBBSYS_STATUSINFO:
                    cmd_str = "UPDATE [SysStatus].[dbo].[SysStatus] SET updateTime = @updateTime, subsys_info = @subsys_info WHERE c_keys = @c_keys AND company = @company AND sys_no = @sys_no ";
                    break;
                case SqlQueryAction.REGISTER_SYSTATUS_INFO:
                    cmd_str = "INSERT INTO [SysStatus].[dbo].[SysStatus] VALUES (@c_keys, @company, @sys_no, @sys_status, @updateTime, @subsys_info) ";
                    break;
                case SqlQueryAction.GET_ALL_INFO:
                    cmd_str = "SELECT * FROM [SysStatus].[dbo].[SysStatus] where c_keys = @c_keys AND company = @company order by updateTime desc ";
                    break;
                case SqlQueryAction.GET_SPECIFIC_INFO:
                    cmd_str = "SELECT * FROM [SysStatus].[dbo].[SysStatus] where c_keys = @c_keys AND sys_no = @sys_no AND company = @company ";
                    break;
                case SqlQueryAction.GET_CURRENT_INFO:
                    cmd_str = "SELECT TOP(1) * FROM [SysStatus].[dbo].[SysStatus] where c_keys = @c_keys AND company = @company order by updateTime desc";
                    break;
                case SqlQueryAction.GET_EXCUTE_TIME_ALL:
                    break;
                case SqlQueryAction.GET_EXCUTE_TIME_SYSNO:
                    break;
                case SqlQueryAction.GET_SYSINFO:
                    cmd_str = "SELECT * FROM [SysStatus].[dbo].[SysStatus] where c_keys = @c_keys AND company = @company AND sys_no = @sys_no ";
                    break;
                default:
                    break;
            }
            return new SqlCommand(cmd_str, conn);
        }
        public SqlCommand SetParameter(SqlQueryAction SqlAction, SqlCommand SqlCommand, string Value)
        {
            string[] data;
            switch (SqlAction)
            {
                case SqlQueryAction.ADD_NEWSUBBSYS_STATUSINFO:
                    data = Regex.Split(Value, ",,,,,");
                    SqlCommand.Parameters.AddWithValue("@c_keys", data[0]);
                    SqlCommand.Parameters.AddWithValue("@company", data[1]);
                    SqlCommand.Parameters.AddWithValue("@sys_no", data[2]);
                    SqlCommand.Parameters.AddWithValue("@subsys_info", data[3]);
                    SqlCommand.Parameters.AddWithValue("@updateTime", data[4]);
                    break;
                case SqlQueryAction.REGISTER_SYSTATUS_INFO:
                    data = Regex.Split(Value, ",,,,,");
                    SqlCommand.Parameters.AddWithValue("@c_keys", data[0]);
                    SqlCommand.Parameters.AddWithValue("@company", data[1]);
                    SqlCommand.Parameters.AddWithValue("@sys_no", data[2]);
                    SqlCommand.Parameters.AddWithValue("@sys_status", data[3]);
                    SqlCommand.Parameters.AddWithValue("@updateTime", data[4]);
                    SqlCommand.Parameters.AddWithValue("@subsys_info", data[5]);
                    break;
                case SqlQueryAction.GET_ALL_INFO:
                    data = Regex.Split(Value, ",,,,,");
                    SqlCommand.Parameters.AddWithValue("@c_keys", data[0]);
                    SqlCommand.Parameters.AddWithValue("@company", data[1]);
                    break;
                case SqlQueryAction.GET_SPECIFIC_INFO:
                    data = Regex.Split(Value, ",,,,,");
                    SqlCommand.Parameters.AddWithValue("@c_keys", data[0]);
                    SqlCommand.Parameters.AddWithValue("@company", data[1]);
                    SqlCommand.Parameters.AddWithValue("@sys_no", data[2]);
                    break;
                case SqlQueryAction.GET_CURRENT_INFO:
                    data = Regex.Split(Value, ",,,,,");
                    SqlCommand.Parameters.AddWithValue("@c_keys", data[0]);
                    SqlCommand.Parameters.AddWithValue("@company", data[1]);
                    break;
                case SqlQueryAction.GET_EXCUTE_TIME_ALL:
                    break;
                case SqlQueryAction.GET_EXCUTE_TIME_SYSNO:
                    break;
                case SqlQueryAction.GET_SYSINFO:
                    data = Regex.Split(Value, ",,,,,");
                    SqlCommand.Parameters.AddWithValue("@c_keys", data[0]);
                    SqlCommand.Parameters.AddWithValue("@company", data[1]);
                    SqlCommand.Parameters.AddWithValue("@sys_no", data[2]);
                    break;
                default:
                    break;
            }
            return SqlCommand;
        }
        public ExcuteResultSql Excute(SqlQueryCategory SqlQueryCategory, SqlQueryAction SqlQueryAction, SqlConnection conn, SqlCommand SqlCommand)
        {
            ExcuteResultSql excuteResultSql = new ExcuteResultSql();
            SqlDaoData dao = SqlDaoData.getInstance();
            conn.Open();
                switch (SqlQueryCategory)
                {
                    case SqlQueryCategory.Insert:
                        SqlCommand.ExecuteNonQuery();
                        break;
                    case SqlQueryCategory.Update:
                        SqlCommand.ExecuteNonQuery();
                        break;
                    case SqlQueryCategory.GET:
                        DataTable dt = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlCommand);
                        sqlDataAdapter.Fill(dt);
                        excuteResultSql.SqlExcuteResultJsonData = dao.ConvertSQLToData(SqlQueryAction, dt);
                        break;
                    default:
                        break;
                }
            conn.Close();

            excuteResultSql.isSuccess = true;
            if (excuteResultSql.SqlExcuteResultJsonData != null && excuteResultSql.SqlExcuteResultJsonData.Equals("[]")) { excuteResultSql.FeedBackMsg = "查無資料，請重新確認"; } else { excuteResultSql.FeedBackMsg = "查詢成功"; }
            return excuteResultSql;
        }
        private string Decryption(string CipherText)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    //加密金鑰(32 Byte)
                    aesAlg.Key = Encoding.Unicode.GetBytes("每個失落的難關，都是善意的安排。");
                    //初始向量(Initial Vector, iv) 類似雜湊演算法中的加密鹽(16 Byte)
                    aesAlg.IV = Encoding.Unicode.GetBytes("以身作則以德服人");
                    //加密器
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    //執行解密
                    byte[] decrypted = decryptor.TransformFinalBlock(Convert.FromBase64String(CipherText), 0, Convert.FromBase64String(CipherText).Length);
                    return Encoding.Unicode.GetString(decrypted);
                }
            }
            catch (Exception)
            {

                return "金鑰、密鑰並匹配，請重新確認。";
            }

        }

    }

    
}
