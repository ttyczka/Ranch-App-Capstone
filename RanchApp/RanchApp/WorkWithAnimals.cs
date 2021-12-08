using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class WorkWithAnimals
    {
        [PrimaryKey, AutoIncrement]
        public int workId { get; set; }
        public string workDate { get; set; }
        public string workAction { get; set; }
        public string workMaterialsUsed { get; set; }
        public string workQuantity { get; set; }
        public string workUnit { get; set; }
        public string workComments { get; set; }
    }
}
