using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
   public class Account
    {
        private  float balance;
        public Account()
        {
            balance = 5000; //By default
        }
        public Account(float amount)
        {
            if(amount ==0)
            {
                throw new ArgumentException("Initial balance should not be 0");
            }
            this.balance = amount;
        }

    }
}
