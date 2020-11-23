using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class BankAccount
    {

        public string AccountOwnerName { get; set; }


        public string AccountNumber { get; set; }


        public double AccountBalance { get; protected set; }


        protected double MinAccountBalance { get; set; }


        protected double MaxDepositAmount { get; set; }

        protected double InteresetRate { get; set; }


        protected string TransactionSummary { get; set; }

        protected BankAccount(string accountOwnerName, string accountNumber)
        {
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            TransactionSummary = string.Empty;
        }



        public abstract void Deposit(double amount);


        public abstract void Withdraw(double amount);

        public double CalculateInterest()
        {
            return (this.AccountBalance * this.InteresetRate) / 100;
        }


        public virtual void GenerateAccountReport()
        {
            Console.WriteLine("Account Owner:{0}, Account Number:{1}, AccountBalance:{2}",
                this.AccountOwnerName, this.AccountNumber, this.AccountBalance);

            Console.WriteLine("Interest Amount:{0}", CalculateInterest());
            Console.WriteLine("{0}", this.TransactionSummary);
        }
    }
}
