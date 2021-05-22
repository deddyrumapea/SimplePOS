using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS
{
    class Transaction
    {
        public int id { get; set; }
        public string date { get; set; }
        public int total { get; set; }
        public int cash { get; set; }
        public int change { get; set; }
        private string connString;
        private MySqlConnection conn;

        public Transaction()
        {
            this.connString = ConfigurationManager.ConnectionStrings["simplepos"].ConnectionString;
            this.conn = new MySqlConnection(connString);
        }

        public Transaction(int id, string date, int total, int cash, int change)
        {
            this.id = id;
            this.date = date;
            this.total = total;
            this.cash = cash;
            this.change = change;
            this.connString = ConfigurationManager.ConnectionStrings["simplepos"].ConnectionString;
            this.conn = new MySqlConnection(connString);
        }

        public string Insert(string date, int total, int cash, int change)
        {
            string result = "";
            using (conn)
            {
                conn.Open();
                string cmdText = "INSERT INTO transaction (date, total, cash, `change`) VALUES (@date, @total, @cash, @change)";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@cash", cash);
                    cmd.Parameters.AddWithValue("@change", change);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result = e.Message;
                    }
                }

                conn.Close();
            }
            return result;
        }

        public DataTable FindAll()
        {
            DataTable dataTable = new DataTable();

            using (conn)
            {
                conn.Open();
                string cmdText = "SELECT id, date, total FROM transaction";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                }

                conn.Close();
            }
            return dataTable;
        }

        public Transaction Find(int id)
        {
            Transaction transaction = null;
            using (conn)
            {
                conn.Open();
                string cmdText = "SELECT * FROM transaction WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    using (dataReader)
                    {
                        while (dataReader.Read())
                        {
                            string date = dataReader.GetString(1);
                            int total = dataReader.GetInt32(2);
                            int cash = dataReader.GetInt32(3);
                            int change = dataReader.GetInt32(4);
                            transaction = new Transaction(id, date, total, cash, change);
                        }
                        dataReader.Close();
                    }
                }
                conn.Close();
            }
            return transaction;
        }

        public string Update(Transaction transaction)
        {
            string result = "";

            using (conn)
            {
                conn.Open();
                string cmdText = "UPDATE transaction SET date=@date, total=@total, cash=@cash, `change`=@change WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@id", transaction.id);
                    cmd.Parameters.AddWithValue("@date", transaction.date);
                    cmd.Parameters.AddWithValue("@total", transaction.total);
                    cmd.Parameters.AddWithValue("@cash", transaction.cash);
                    cmd.Parameters.AddWithValue("@change", transaction.change);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result = e.Message;
                    }
                }
                conn.Close();
            }

            return result;
        }

        public string Delete(int id)
        {
            string result = "";

            using (conn)
            {
                conn.Open();
                string cmdText = "DELETE FROM transaction WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result = e.Message;
                    }
                }
                conn.Close();
            }
            return result;
        }

        public int LastInsertedId()
        {
            int result = 0;
            using (conn)
            {
                conn.Open();
                string cmdText = "SELECT MAX(id) FROM transaction";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    result = dataReader.GetInt32(0);
                    dataReader.Close();
                }

                conn.Close();
            }
            return result;
        }
    }
}
