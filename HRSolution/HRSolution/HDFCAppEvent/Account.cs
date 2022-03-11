using Gov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
       

        public event BankOperation underBalance; //type
        public event TaxOperation overBalance;

        public double Balance { get; set; }

        public Account(double amount)
        {
            this.Balance = amount;
        }

        public void Deposite(double amount)
        {
            this.Balance = this.Balance + amount;

            if(Balance > 300000)
            {
                //raise an event
                overBalance();
            }
        }

        public void Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;

            if(Balance <= 100000)
            {
                underBalance();
            }
        }




    }
}
