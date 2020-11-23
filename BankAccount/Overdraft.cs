using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Overdraft : BankAccount
    {
        private int overdraftLimit;
        public int OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

  
        public Overdraft (string accountOwnerName, string accountNumber)
       : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 500;
            this.MaxDepositAmount = 100000000;
            InteresetRate = .25;
        }
        public override void Withdraw(double amount)
        {

            if (AccountBalance - amount >= 500)
            {
                AccountBalance -= amount;
            }
            else
                Console.WriteLine("\nInsufficient Balance");
        }
    }
}