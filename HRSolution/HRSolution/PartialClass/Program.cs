using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.FirstName = "Ankita";
            cust.LastName = "Kharat";
            cust.OrderId = 100;
            cust.OrderStatus = "Processing";

            Console.WriteLine(cust.FirstName + " " + cust.LastName + " " + cust.OrderId + " " + cust.OrderStatus);
            Console.ReadLine();
        }
    }
}
