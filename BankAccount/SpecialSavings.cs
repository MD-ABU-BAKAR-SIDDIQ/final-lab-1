using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class SpecialSavings : BankAccount
    {

        private int trans;
        public int Trans
        {
            get { return trans; }
            set { trans = value; }
        }
        private int noTrans;
        public int NoTrans
        {
            get { return noTrans; }
            set { noTrans = value; }
        }

        public SpecialSavings(double amount, int trans, int noTrans, string accountOwnerName, string accountNumber, double AccountBalance) : base(accountOwnerName, accountNumber)
        {
            this.trans = trans;
            this.noTrans = noTrans;
            
            if (noTrans < trans)
            {

                AccountBalance += amount;
            }
            else
                Console.WriteLine("Not following minimal number of monthly transaction");
        }
        public override void Withdraw(double amount)
        {

            if (AccountBalance - amount >= AccountBalance * 0.2)
            {
                AccountBalance -= amount;
            }
            else
                Console.WriteLine("Withdraw Balance Must Be Minimum 20% Of Openning Balance");
        }
    }
}
