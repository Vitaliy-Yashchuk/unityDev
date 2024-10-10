using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DB_project
{
     class DB
    {
        private const string HOST = "localhost";
        private const string PORT = "3306";
        private const string DATABASE = "mysql_db";
        private const string USER = "root";
        private const string PASS = "root";

        private string connect;

        public DB() 
        { 
             connect =$"Server={HOST}; User={USER};Password={PASS};Database={DATABASE};Port={PORT};";
        }
        public async Task Connect() 
        {
            using(MySqlConnection conn=new MySqlConnection(connect))
            {
                await conn.OpenAsync();
                Console.WriteLine("Open");
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS `users` ("+
                    "id INT(11) AUTO_INCREMENT PRIMARY KEY,"+
                    "login VARCHAR(50),"+
                    "password VARCHAR(50)"+
                    ") ENGINE=MYISAM";
                command.Connection = conn;
                await command.ExecuteNonQueryAsync();
            }
            using(MySqlConnection conn=new MySqlConnection(connect))
            {
                await conn.OpenAsync();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS `Book`(" +
                    "id INT(6) AUTO_INCREMENT PRIMARY KEY," +
                    "title VARCHAR(100)," +
                    "author VARCHAR(50)," +
                    "publication_year INT(11)," +
                    "genre VARCHAR(30)" +
                    ") ENGINE=MYISAM";
                command.Connection = conn;
                await command.ExecuteNonQueryAsync();
                
            }
        }
    }
}
