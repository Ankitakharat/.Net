using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp;


namespace HDFCbankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account acct = new Account(0);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {

            }
            Console.ReadLine();
        }
    }
}
    
