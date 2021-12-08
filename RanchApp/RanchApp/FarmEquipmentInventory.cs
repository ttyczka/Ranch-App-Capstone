using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class FarmEquipmentInventory
    {
        [PrimaryKey, AutoIncrement]
        public int equipId { get; set; }
        public string equipPurchaseDate { get; set; }
        public string equipName { get; set; }
        public string equipMake { get; set; }
        public string equipModel { get; set; }
        public string equipHours { get; set; }
        public decimal equipPurchaseCost { get; set; }
        public string equipVender { get; set; }
        public string equipStorageLocation { get; set; }
    }
}
