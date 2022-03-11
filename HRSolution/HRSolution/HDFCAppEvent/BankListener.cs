using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public delegate void BankOperation(); //declaration part
   public class BankListener
    {
        public static void SendEmail()
        {
            Console.WriteLine("Registered email address.");
        }
        public static void SendSMS()
        {
            Console.WriteLine(" Registered mobile number.");
        }
        public static void BlockAccount()
        {
            Console.WriteLine("Account has been blocked Temp. , contact relationship manager....");
        }

    }
}
