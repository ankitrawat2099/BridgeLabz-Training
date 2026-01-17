using System;
using System.Collections.Generic;
using System.Text;

namespace Review.BankAccountManager
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        void WithDraw(double amount);
        void CheckBalance();

    }
}
