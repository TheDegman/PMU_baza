using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMU_baza
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Rezije>();
        }

        public Task<List<Rezije>> GetPeopleAsync()
        {
            return _database.Table<Rezije>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Rezije rezije)
        {
            return _database.InsertAsync(rezije);
        }
    }
}
