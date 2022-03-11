using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using BOL;

namespace DAL1
{
    public class ProductDAO
    {
        public static string conString = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        public static List<Product> GetAll()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
            List<Product> allProducts = new List<Product>();
            try
            {
                con.Open();
                string query = "SELECT * FROM PRODUCT";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Id = int.Parse(reader["id"].ToString());
                    string Name = reader["name"].ToString();
                    string Description = reader["discription"].ToString();
                    string Price = reader["price"].ToString();

                    Product prod = new Product();

                    prod.id = Id;
                    prod.name = Name;
                    prod.discription = Description;
                    prod.price = double.Parse(Price);
                    allProducts.Add(prod);

                    // Console.WriteLine(name + " " + salary + " " + designation);

                }
            }
            catch (MySqlException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allProducts;
        }


        public static Product Get(int prodId)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
            Product prod = null;

            try
            {
                con.Open();

                string query = "SELECT * FROM PRODUCT WHERE ID=" + prodId;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Id = int.Parse(reader["id"].ToString());
                    string Name = reader["name"].ToString();
                    string Desc = reader["discription"].ToString();
                    string Price = reader["price"].ToString();

                    prod = new Product();
                    prod.id = Id;
                    prod.name = Name;
                    prod.discription = Desc;
                    prod.price = double.Parse(Price);
                }
                reader.Close();
            }
            catch (MySqlException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return prod;
        }

        public static bool Insert(Product prod)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;

            try
            {
                con.Open();
                string query = "INSERT INTO PRODUCT VALUES(" + prod.id + ",'" + prod.name + "','" + prod.discription + "'," + prod.price + ")";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                status = true;
            }

            catch (MySqlException exp)
            {
                Console.WriteLine(exp.Message);
            }

            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return status;
        }

        public static bool Update(int id,string name)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;

            try
            {
                con.Open();
                string query = "update product set name= '" +name + "' where id=" + id;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                status = true;
            }

            catch (MySqlException exp)
            {
                Console.WriteLine(exp.Message);
            }

            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return status;
        }

        public static bool Delete(int prodId)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;


            try
            {
                con.Open();

                string query = "DELETE FROM PRODUCT WHERE ID=" + prodId;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                status = true;
            }

            catch (MySqlException exp)
            {
                Console.WriteLine(exp.Message);
            }

            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return status;
        }


    }
}