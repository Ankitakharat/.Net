using BLL;
using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager mgr = new EmployeeManager();
            List<Employee> emp = mgr.GetAll();
            foreach(Employee emp1 in emp)
            {
                string result = string.Format("{0}--------{1}---------{2}",emp1.Id,emp1.Name,emp1.Departement);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
