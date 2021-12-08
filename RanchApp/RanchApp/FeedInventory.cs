using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class FeedInventory
    {
        [PrimaryKey, AutoIncrement]
        public int feedInputId { get; set; }
        public string feedDate { get; set; }
        public string feedName { get; set; }
        public decimal feedQuantity { get; set; }
        public string feedUnit { get; set; }
    }
}
