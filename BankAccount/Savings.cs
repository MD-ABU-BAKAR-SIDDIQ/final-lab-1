using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingBankAccount : BankAccount
    {
        protected int withdrawCount = 0;

        public SavingBankAccount(string accountOwnerName, string accountNumber)
            : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 500;
            this.MaxDepositAmount = 50000;
            InteresetRate = 3.5;
        }

        public override void Deposit(double amount)
        {
            if (amount >= MaxDepositAmount)
            {
                throw new Exception(string.Format("\nYou can not deposit amount greater than {0}", MaxDepositAmount.ToString()));
            }

            AccountBalance = AccountBalance + amount;

            TransactionSummary = string.Format("{0}\n Deposit:{1}",TransactionSummary, amount);
        }

        public override void Withdraw(double amount)
        {

            if (withdrawCount > 3)
            {
                throw new Exception("\nYou can not withdraw amount more than thrice");
            }

            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new Exception("\nYou can not withdraw amount from your Savings Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            withdrawCount++;

            TransactionSummary = string.Format("{0}\n Withdraw:{1}",TransactionSummary, amount);
        }

        public override void GenerateAccountReport()
        {
            Console.WriteLine("\nSaving Account Report");
            base.GenerateAccountReport();


            if (AccountBalance > 15000)
            {
                Console.WriteLine("\nSending Email for Account {0}", AccountNumber);
            }
        }
    }
}