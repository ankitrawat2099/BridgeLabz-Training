using System;
using System.Collections.Generic;
using System.Text;

namespace Review.BankAccountManager
{
   public class BankAccountUtilityImpl:IBankAccount
    {
        BankAccount b;
        public BankAccountUtilityImpl(BankAccount account)
        {
            b = account;
        }
        public void CheckBalance()
        {
            if (b.GetBalance() <= 0)
            {
                Console.WriteLine("insufficeint balance");
                return;
            }
            else
            {
                Console.WriteLine(b.GetBalance());
            }
        }
        public void Deposit(double amount)
        {
            double prevBalance=b.GetBalance();
            double newBalance=prevBalance+amount;
            b.SetBalance(newBalance);
        }
        public void WithDraw(double amount) {
            if (b.GetBalance() <= amount)
            {
                Console.WriteLine("insufficeint balnce");
                return;
            }
            double prevBalance1=b.GetBalance();
            double newBalance1 =prevBalance1-amount;
            b.SetBalance(newBalance1);
        }
    }

}
