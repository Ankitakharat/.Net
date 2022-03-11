using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Specific employee");

            /* List<Employee> emp = EmployeeDAO.GetAll();
            foreach (Employee emp1 in emp)
            {
                Console.WriteLine(emp1.Id + " " + emp1.Name + " " + emp1.Department);
            }*/

            /* int id = 2;
             Employee employee = EmployeeDAO.Get(id);

             Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Department);

             */

            /* int id = 4;
             bool status = EmployeeDAO.Delete(id);
             if(status)
             {
                 Console.WriteLine("Record " + id + " Removed from taBLE SUCCESSFULLY!!!!");
             }

             */
            Employee emp2 =new Employee();
            emp2.Id = 4;
            emp2.Name = "Tushar";
            emp2.Department = "AI Enginner";

            bool status = EmployeeDAO.Insert(emp2);
            if (status)
            {
                Console.WriteLine("Record insert in table SUCCESSFULLY!!!!");
            }

            Console.ReadLine();
        }
    }
}

      
