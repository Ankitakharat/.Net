using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRlib
{
   public class Employee:Person
    {

        public int Department { get; set; }
        public string Location { get; set; }
        public int BasicSalary { get; set; }
        public double DailyAllowance { get; set; }

        public Employee(string firstName, string lastName, string email, string phoneNumber,int department, string location, int basicSalary, double dailyAllowance) :base(firstName,lastName,email, phoneNumber)
        {
            this.Department = department;
            this.Location = location;
            this.BasicSalary = basicSalary;
            this.DailyAllowance = dailyAllowance;
        }

        public override string ToString()
        {
            return base.ToString()+" "+this.Department+" "+this.Location+" "+this.BasicSalary+" "+this.DailyAllowance; 
        }

        public virtual double ComputeSalary()
        {
            return this.BasicSalary + (this.DailyAllowance * 30);
        }
    }
}
