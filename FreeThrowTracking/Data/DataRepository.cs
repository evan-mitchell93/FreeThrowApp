using FreeThrowTracking.Maui.Models;
using SQLite;


namespace FreeThrowTracking.Maui.Data
{
    public class DataRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public DataRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Player>();
        }
    }
}