using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RanchApp
{
    public class AnimalInventory
    {
        [PrimaryKey, AutoIncrement]
        public int animalId { get; set; }
        public string animalTag { get; set; }
        public string animalName { get; set; }
        public string animalSpecies { get; set; }
        public string animalBreed { get; set; }
        public string animalSex { get; set; }
        public string animalArivalDate { get; set; }
        public string animalPhoto { get; set; }
        
    }
}
