using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCAppEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instace Creation
            Account acct123 = new Account(60000);

            //Event Configuration
            //Add Hook to your account instance
            //Attach event handlers to event of an instace Account

            acct123.underBalance += new BankOperation(BankListener.BlockAccount);
            acct123.underBalance += new BankOperation(BankListener.SendEmail);
            acct123.underBalance += new BankOperation(BankListener.SendSMS);

            acct123.overBalance += new Gov.TaxOperation(Gov.GovtListener.PayIncomeTax);
            acct123.overBalance += new Gov.TaxOperation(Gov.GovtListener.PayServiceTax);

            //KISS
            //Keep it Simple and Stupid


            //Transation Management
            Console.WriteLine("Please enter amount to deposit");
            double amount = double.Parse(Console.ReadLine());
            //acct123.Widthdraw(amount);
            acct123.Deposite(amount);
            //Report Output
            Console.WriteLine("Remaining Balance= " + acct123.Balance);
            Console.ReadLine();
        }
    }
}
