using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRlib;

namespace HRSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer d = new Developer("Ankita", "Kharat", "ankitakharat123@gmail.com", "9834378044", 1, "PUNE", 60000, 500, 25000);
            Console.WriteLine(d);
            Console.WriteLine(d.ComputeSalary());
            Console.ReadLine();
        }
    }
}
