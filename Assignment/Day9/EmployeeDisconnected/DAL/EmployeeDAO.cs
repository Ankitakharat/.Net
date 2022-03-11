using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using BOL;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class EmployeeDAO
    {
        public static string conString = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employee = new List<Employee>();
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM EMPLOYEES;SELECT * FROM TASKS";

            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                DataTable dtEmp = ds.Tables[0];
                DataTable dbTask = ds.Tables[0];
                DataRowCollection rows = dtEmp.Rows;
                foreach(DataRow row in rows)
                {
                    Employee emp = new Employee();
                    emp.Id = int.Parse(row["Id"].ToString());
                    emp.Name = row["Name"].ToString();
                    emp.Departement = row["Department"].ToString();
                    employee.Add(emp);
                }

            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }
    }
}
