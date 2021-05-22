using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace SimplePOS
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        private string connString;
        private MySqlConnection conn;

        public Product()
        {
            this.connString = ConfigurationManager.ConnectionStrings["simplepos"].ConnectionString;
            this.conn = new MySqlConnection(connString);
        }

        public Product(int id, string name, int price, int stock)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.connString = ConfigurationManager.ConnectionStrings["simplepos"].ConnectionString;
            this.conn = new MySqlConnection(connString);
        }

        public string Insert(string name, int price, int stock)
        {
            string result = "";
            using (conn)
            {
                conn.Open();
                string cmdText = "INSERT INTO product (name, price, stock) VALUES (@name, @price, @stock)";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);

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
                string cmdText = "SELECT * FROM product";
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

        public Product Find(int id)
        {
            Product product = null;
            using (conn)
            {
                conn.Open();
                string cmdText = "SELECT * FROM product WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    using (dataReader)
                    {
                        while (dataReader.Read())
                        {
                            string name = dataReader.GetString(1);
                            int price = dataReader.GetInt32(2);
                            int stock = dataReader.GetInt32(3);
                            product = new Product(id, name, price, stock);
                        }
                        dataReader.Close();
                    }

                }
                conn.Close();
            }
            return product;
        }

        public string Update(int id, string name, int price, int stock)
        {
            string result = "";
            using (conn)
            {
                conn.Open();
                string cmdText = "UPDATE product SET name=@name, price=@price, stock=@stock WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);

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
                string cmdText = "DELETE FROM product WHERE id=@id";
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

        public string InsertToTransaction(int transactionId, int productId, int quantity)
        {
            string result = "";

            using (conn)
            {
                conn.Open();
                string cmdText1 = "INSERT INTO transaction_product (id_transaction, id_product, quantity) VALUES (@id_transaction, @id_product, @quantity)";
                MySqlCommand cmd1 = new MySqlCommand(cmdText1, conn);

                using (cmd1)
                {
                    cmd1.Parameters.AddWithValue("@id_transaction", transactionId);
                    cmd1.Parameters.AddWithValue("@id_product", productId);
                    cmd1.Parameters.AddWithValue("@quantity", quantity);

                    try
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result = e.Message;
                    }
                }

                string cmdText2 = "UPDATE product SET stock=(stock - @quantity) WHERE id=@id";
                MySqlCommand cmd2 = new MySqlCommand(cmdText2, conn);
                using (cmd2)
                {
                    cmd2.Parameters.AddWithValue("@id", productId);
                    cmd2.Parameters.AddWithValue("@quantity", quantity);

                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result += e.Message;
                    }
                }
                conn.Close();
            }

            return result;
        }

        public DataTable FindFromTransaction(int transactionId)
        {
            DataTable dataTable = new DataTable();
            using (conn)
            {
                conn.Open();
                string cmdText = "SELECT id_product AS 'id', name, price, quantity, price*quantity AS subtotal " +
                    "FROM product, transaction_product " +
                    "WHERE transaction_product.id_product = product.id " +
                    "AND transaction_product.id_transaction = @transactionId";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@transactionId", transactionId);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                }
                conn.Close();
            }
            return dataTable;
        }

        public int GenerateFreshId()
        {
            int id = 0;
            using (conn)
            {
                conn.Open();
                string cmdText = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'simplepos' AND TABLE_NAME = 'product'";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                using (cmd)
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    id += dataReader.GetInt32(0);
                    dataReader.Close();
                }

                conn.Close();
            }
            return id;
        }
    }
}