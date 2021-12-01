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
        }
        public Task<List<Animal>> GetAnimalAsync()
        {
            return _database.Table<Animal>().ToListAsync();
        }
        public Task<int> SaveAnimalAsync(Animal animal)
        {
            return _database.InsertAsync(animal);
        }
    }
}

