using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace RanchApp
{
    public class RanchDatabase
    {
            private readonly SQLiteAsyncConnection _database;

        public RanchDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Animal>().Wait();
            _database.CreateTableAsync<AnimalInventory>().Wait();
            _database.CreateTableAsync<BorrowedEquipment>().Wait();
            _database.CreateTableAsync<CheckIn>().Wait();
            _database.CreateTableAsync<FarmEquipmentInventory>().Wait();
            _database.CreateTableAsync<FeedInventory>().Wait();
            _database.CreateTableAsync<GasLog>().Wait();
            _database.CreateTableAsync<WorkWithAnimals>().Wait();
        }
        public Task<List<Animal>> GetAnimalAsync()
        {
            return _database.Table<Animal>().ToListAsync();
        }
        public Task<List<AnimalInventory>> GetAnimalInventoryAsync()
        {
            return _database.Table<AnimalInventory>().ToListAsync();
        }

        public Task<List<BorrowedEquipment>> GetBorrowedEquipmentAsync()
        {
            return _database.Table<BorrowedEquipment>().ToListAsync();
        }
        public Task<List<CheckIn>> GetCheckInAsync()
        {
            return _database.Table<CheckIn>().ToListAsync();
        }
        public Task<List<FarmEquipmentInventory>> GetFarmEquipmentInventorytAsync()
        {
            return _database.Table<FarmEquipmentInventory>().ToListAsync();
        }
        public Task<List<FeedInventory>> GetFeedInventoryAsync()
        {
            return _database.Table<FeedInventory>().ToListAsync();
        }
        public Task<List<GasLog>> GetGasLogAsync()
        {
            return _database.Table<GasLog>().ToListAsync();
        }
        public Task<List<WorkWithAnimals>> GetWorkWithAnimalsAsync()
        {
            return _database.Table<WorkWithAnimals>().ToListAsync();
        }



        public Task<int> SaveAnimalAsync(Animal animal)
        {
            return _database.InsertAsync(animal);
        }
        
        public Task<int> SaveAnimalInventoryAsync(AnimalInventory animalInventory)
        {
            return _database.InsertAsync(animalInventory);
        }
        
        public Task<int> SaveBorrowedEquipmentAsync(BorrowedEquipment borrowedEquipment)
        {
            return _database.InsertAsync(borrowedEquipment);
        }
        public Task<int> SaveCheckInAsync(CheckIn checkIn)
        {
            return _database.InsertAsync(checkIn);
        }
        public Task<int> SaveFarmEquipmentInventoryAsync(FarmEquipmentInventory farmEquipmentInventory)
        {
            return _database.InsertAsync(farmEquipmentInventory);
        }
        public Task<int> SaveFeedInventoryAsync(FeedInventory feedInventory)
        {
            return _database.InsertAsync(feedInventory);
        }
        public Task<int> SaveGasLogAsync(GasLog gasLog)
        {
            return _database.InsertAsync(gasLog);
        } public Task<int> SaveWorkWithAnimalsAsync(WorkWithAnimals workWithAnimals)
        {
            return _database.InsertAsync(workWithAnimals);
        }
    }
}

