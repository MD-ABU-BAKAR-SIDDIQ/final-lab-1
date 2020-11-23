using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savingAccount = new SavingBankAccount("Siddiq", "S12345");
            BankAccount FixedAccount = new FixedAccount("bakar", "C12345");
       

            savingAccount.Deposit(40000);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(1000);
            savingAccount.GenerateAccountReport();


            Console.WriteLine();
            FixedAccount.Deposit(190000);
            FixedAccount.Withdraw(1000);
            FixedAccount.GenerateAccountReport();
            Console.ReadLine();

        }
    }
}
    