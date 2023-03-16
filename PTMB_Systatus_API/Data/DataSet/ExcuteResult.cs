using PTMB_Systatus_API.Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMB_Systatus_API.Data.DataSet
{
    public class ExcuteResultSql
    {
        public bool isSuccess { get; set; }
        public string FeedBackMsg { get; set; }   
        public string FailReason { get; set; }
        public string SqlExcuteResultJsonData { get; set; }
    }

    public class ExcuteResultInfo
    {
        public bool isSuccess { get; set; }
        public string FeedBackMsg { get; set; }
        public string FailReason { get; set; }
    }

}
