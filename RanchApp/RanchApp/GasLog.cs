using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class GasLog
    {
        [PrimaryKey, AutoIncrement]
        public int gasId { get; set; }
        public string gasTankNumber { get; set; }
        public string gasDate { get; set; }
        public string stationName { get; set; }
        public decimal gasGallons { get; set; }
        public decimal gasPricePerGallon { get; set; }
    }
}
