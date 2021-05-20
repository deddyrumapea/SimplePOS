using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace SimplePOS
{
    class Product
    {
        private string connString = ConfigurationManager.ConnectionStrings["simplepos"].ConnectionString;

        public string Insert(string name, int price, int stock)
        {
            string result = "";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO product (name, price, stock) VALUES (@name, @price, @stock)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }catch(Exception e)
                    {
                        result = e.Message;
                    }
                }
            }
            return result;
        }

        public DataTable FindAll()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM product", conn))
                {
                    conn.Open();
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                }
            }
            return dataTable;
        }
    }
}
