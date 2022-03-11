using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRlib
{
    public class Developer : Employee
    {
        public double Incentive { get; set; }

        public Developer(string firstName, string lastName, string email, string phoneNumber, int department, string location, int basicSalary, double dailyAllowance, double incentive) : base(firstName, lastName, email, phoneNumber, department, location, basicSalary, dailyAllowance)
        {
            this.Incentive = incentive;
        }

        public override string ToString()
        {
            return base.ToString()+" "+this.Incentive; 
        }
        public override double ComputeSalary()
        {
            Console.WriteLine("Developer Salary:");
            return base.BasicSalary+(base.DailyAllowance*30)+this.Incentive;
        }


    }


}
