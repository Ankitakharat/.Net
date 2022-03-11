using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(1,"Ankita",1000);
            Console.WriteLine("id:" + ac.AccountId + "  Name:" + ac.AccountHolder + "  Balance:" + ac.Balance);
            Console.WriteLine("Input the deposite amount: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("deposited amount is: "+d);
            
            Console.Write("Balance after Deposite :");
            ac.deposite(d);
            ac.display();

            Console.WriteLine("Input the withdraw amount: ");
            double w = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("withdraw Amount  is: " + w);
            Console.Write("Balance after Withdraw :");
            ac.withdraw(w);
            ac.display();

            Console.ReadLine();

        }
    }
}
