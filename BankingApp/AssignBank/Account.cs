using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignBank
{
    class Account
    {
        private int accountId;
        private string accountHolder;
        private double balance;
        public Account()
        {
            balance = 5000;
        }
        public Account(int accountId, string accountHolder, double balance)
        {
            if (balance == 0)
            {
                throw new ArgumentException("Initial balance should not be 0");
            }
            else
            {
                this.accountId = accountId;
                this.accountHolder = accountHolder;
                this.balance = balance;
            }
       }

        public int AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }  
        }
        public string AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
       
        public void deposite(double amount)
        {
            this.balance = this.balance + amount;
        }
        public void withdraw(double amount)
        {
            this.balance = this.balance - amount;
        }

        public void display()
        {
            Console.WriteLine(this.balance+" /- Rs");
        }


    }
}
