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
        public async Task CreateTable() 
        {
            using(MySqlConnection conn=new MySqlConnection(connect))
            {

                string sql = "CREATE TABLE IF NOT EXISTS `users` ("+
                    "id INT(11) AUTO_INCREMENT PRIMARY KEY,"+
                    "login VARCHAR(50),"+
                    "password VARCHAR(50)"+
                    ") ENGINE=MYISAM";
                await ExecuteQuery(sql);
            }
        }
        public async Task InsertData(string title, string text, string date,string author)
        {
            string sql = "INSERT INTO `articles`(title,text,date,author) VALUES(@title,@text, @date, @author)";
            Dictionary<string, string> parametrs = new Dictionary<string, string>();
            parametrs.Add("title", title);
            parametrs.Add("text", text);
            parametrs.Add("date", date);
            parametrs.Add("author", author);
            await ExecuteQuery(sql, parametrs);
        }
        private async Task ExecuteQuery(string sql,Dictionary<string, string?>? parameters=null)
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                await conn.OpenAsync();

                MySqlCommand command = new MySqlCommand(sql, conn);
                if(parameters != null)
                {
                    foreach(var el in parameters)
                    {
                        MySqlParameter param = new MySqlParameter($"@{el.Key}", el.Value);
                        command.Parameters.Add(param);
                    }
                }
                await command.ExecuteNonQueryAsync();
            }
        }
        public async Task GetData(int number)
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                await conn.OpenAsync();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `articles` WHERE text LIKE '%oo%' or id >=@number ",conn);
                MySqlParameter param = new MySqlParameter($"@number", number);
                command.Parameters.Add(param);
                MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync()) 
                    {
                        object id = reader["id"];
                        object title = reader["title"];
                        object text = reader["text"];
                        object date = reader["date"];
                        object author = reader["author"];

                        Console.WriteLine($"{id}. {title} - {author}");
                    }
                }
                await reader.CloseAsync();
            }
        }
    }
    
}
