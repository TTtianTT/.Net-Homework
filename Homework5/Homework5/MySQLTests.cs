using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class MySQLTests
    {
        //直接使用provider对象


        private static void DeleteAuthor()
        {
            using(MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("delete from authors where Name='田在隆',connection"))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;" + "password=root;database=book;charset=utf8");
            connection.Open();
            return connection;
        }

        private static void InsertAuthor()
        {
            using (MySqlConnection connection = GetConnection())
            {
                using(MySqlCommand cmd = new MySqlCommand("INSERT INTO Authors(Name) VALUES(@Name)", connection))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Name", "莫言");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //使用DataReader对象
        private static void QueryAuthors()
        {
            using(MySqlConnection connection = GetConnection())
            {
                string stm = "SELECT * FROM Authors";
                using(MySqlCommand cmd = new MySqlCommand(stm,connection))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine(reader.GetInt32(0) + ":" + reader.GetString(1));
                        }
                    }
                }
            }
        }

    }
}
