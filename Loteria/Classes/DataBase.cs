using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loteria.Classes
{
    public class DataBase
    {
        private readonly SQLiteConnection _connection;

        public DataBase(string path)
        {
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<Player>();
            _connection.CreateTable<Score>();
        }

        public int SaveObject<T>(T obiect)
        {
            return _connection.Insert(obiect);
        }

        public List<T> ReadObjects<T>() where T : new()
        {
            return _connection.Table<T>().ToList();
        }
    }
}
