using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ankita","Kharat","ankita@123",9834378044);
            Console.WriteLine(".......................................");

            Person p1 = new Person("Bhagya", "Dhanak", "bahagya@123", 5147512044);

            Console.WriteLine(p.FirstName+" "+ p.LastName+" "+ p.Email+" "+ p.PhnNo);
         
            Console.WriteLine(".......................................");

            Console.WriteLine(p1.FirstName + " " + p1.LastName + " " + p1.Email + " " + p1.PhnNo);

            Console.WriteLine(".......................................");

            Console.WriteLine("Number of Object is"+ Person.getCount());

            Console.ReadLine();
        }
    }
}
