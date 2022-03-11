using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeManager
    {
        public List<Employee> GetAll()
        {
            List<Employee> employee = EmployeeDAO.GetAllEmployees();
            return employee;
        }
    }
}
