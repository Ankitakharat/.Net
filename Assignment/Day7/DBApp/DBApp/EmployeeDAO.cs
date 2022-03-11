using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace DBApp
{
    class EmployeeDAO
    {
        public static List<Employee> GetAll()
        {
            string constring = "server=localhost;user=root;database=dotnet;password='Lovemax@00'";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            List<Employee> allEmployee = new List<Employee>();
            try
            {
                con.Open();
                string query = " SELECT * FROM EMPLOYEES";
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;
                com.CommandText = query;

                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string department = reader["department"].ToString();
                    Employee emp = new Employee();
                    emp.Id = id;
                    emp.Name = name;
                    emp.Department = department;
                    allEmployee.Add(emp);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allEmployee;
        }

        public static Employee Get(int empId)
        {
            string constring = "server=localhost;user=root;database=dotnet;password='Lovemax@00'";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            Employee emp1 = null;
            try
            {
                con.Open();
                string query = " SELECT * FROM EMPLOYEES WHERE ID=" + empId;
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;
                com.CommandText = query;

                MySqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string department = reader["department"].ToString();
                     emp1 = new Employee();
                    emp1.Id = id;
                    emp1.Name = name;
                    emp1.Department = department;
                    
                }
                reader.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return emp1;

        }
        public static bool Delete(int empId)
        {
            bool status = false;
            string constring = "server=localhost;user=root;database=dotnet;password='Lovemax@00'";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            
            
            try
            {
                con.Open();
                string query = " DELETE FROM EMPLOYEES WHERE ID=" + empId;
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;
                com.CommandText = query;
                com.ExecuteNonQuery();
                status = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
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

        public static bool Insert(Employee emp)
        {
            bool status = false;
            string constring = "server=localhost;user=root;database=dotnet;password='Lovemax@00'";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;


            try
            {
                con.Open();
                string query = " INSERT INTO EMPLOYEES(ID,NAME,DEPARTMENT) VALUES(" +emp.Id+" ,'" + emp.Name + "' ,'" + emp.Department+"')";
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;
                com.CommandText = query;
                com.ExecuteNonQuery();
                status = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
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
