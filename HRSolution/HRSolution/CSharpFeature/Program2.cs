using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeature
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Program 2");

            int[] marks = {10,20,30,40};
            String[] names = {"Ankita","Tushar","Komal","Bhagyashri" };

            Product[] catalog =
            {
              new Product{ Id=1,Title="Jasmine", Description="Smelling Flower",UnitPrice=5, Quantity=56000},
              new Product{ Id=13,Title="Lotus", Description="Smelling Flower",UnitPrice=26 ,Quantity=7600},
              new Product{ Id=14,Title="Lily", Description="Beautiful Flower",UnitPrice=12, Quantity=8900},
              new Product{ Id=15,Title="Orchid", Description="Delicate Flower",UnitPrice=12, Quantity=2300},
              new Product{ Id=16,Title="Marigold", Description="Festival Flower",UnitPrice=12, Quantity=6500},
              new Product{ Id=17,Title="Rose", Description="Valentine Flower",UnitPrice=12, Quantity=1200},

            };
            Console.WriteLine(marks[3]);
            Console.WriteLine(names[0]);

            foreach (Product item in catalog)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
