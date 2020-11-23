using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount


{
    public class FixedAccount : BankAccount
    {
        public FixedAccount(string accountOwnerName, string accountNumber)
        : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 500;
            this.MaxDepositAmount = 100000000;
            InteresetRate = .25;
        }

        public override void Deposit(double amount)
        {
            AccountBalance = AccountBalance + amount;
            TransactionSummary = string.Format("{0}\n Deposit:{1}",TransactionSummary, amount);
        }

        public override void Withdraw(double amount)
        {
            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new Exception("\nYou can not withdraw amount from your Current Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            TransactionSummary = string.Format("{0}\n Withdraw:{1}",TransactionSummary, amount);
        }

        public override void GenerateAccountReport()
        {
            Console.WriteLine("\nFixed Account Report");
            base.GenerateAccountReport();
        }
    }
}
