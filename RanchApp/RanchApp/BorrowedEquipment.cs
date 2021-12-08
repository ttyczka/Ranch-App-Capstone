using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class BorrowedEquipment
    {
        [PrimaryKey, AutoIncrement]
        public int barrowId { get; set; }
        public string barrowOwnerName { get; set; }
        public string barrowName { get; set; }
        public string barrowStartDate { get; set; }
        public string barrowStartNotes { get; set; }
        public string barrowCondition { get; set; }
        public string barrowEndtDate { get; set; }
        public string barrowEndNotes { get; set; }
        public string barrowEndCondition { get; set; }
    }
}
