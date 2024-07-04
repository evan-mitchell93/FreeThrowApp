using FreeThrowTracking.Maui.Models;
using SQLite;
using System.Diagnostics;


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
            conn.CreateTable<Team>();
            conn.Tracer = new Action<string>(q => Debug.WriteLine(q));
            conn.Trace = true;
            conn.Query<Team>("INSERT INTO Team (Id, Name) VALUES(1,'Varsity Girls')");
            conn.Query<Player>("INSERT INTO Player (Id,FirstName,LastName,Team,Position) VALUES(1,'Macy','Bush','Varsity Girls','Guard')");
            conn.Query<Player>("INSERT INTO Player (Id,FirstName,LastName,Team,Position) VALUES(2,'Olivet','Killingsworth','Varsity Girls','Guard')");
        }

        public List<Team> GetTeams()
        {
            return conn.Table<Team>().ToList();
        }

        public List<Player> GetPlayersByTeam(String? teamName)
        {
            return conn.Query<Player>($"SELECT * FROM Player WHERE Team LIKE ?", teamName);
        }

        public void DeletePlayerById(int id)
        {
            conn.Delete<Player>(id);
        }
    }
}