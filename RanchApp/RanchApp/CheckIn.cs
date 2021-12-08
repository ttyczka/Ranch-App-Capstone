using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class CheckIn
    {
        [PrimaryKey, AutoIncrement]
        public int empcheckId { get; set; }
        public string empName { get; set; }
        public string empDate { get; set; }
        public string empStartTime { get; set; }
        public string empEndTime { get; set; }
        
    }
}
