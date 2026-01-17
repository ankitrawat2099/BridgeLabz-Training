using System;
using System.Collections.Generic;
using System.Text;

namespace Review.BankAccountManager
{
    public class BankAccountManager
    {
        static void Main()
        {
            Console.WriteLine("enter the bank Account No:");
            int accNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the starting bank balance:");
            double balance = Convert.ToDouble(Console.ReadLine());
            BankAccount b=new BankAccount();
            b.SetBalance(balance);
            b.SetAccountNo(accNumber);
            BankAccountMenu m = new BankAccountMenu(b);
            m.Menu();

        }
    }
}
//Methods – Bank Account Manager
//1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
//● Problem: Design a BankAccount class with :
//● Fields/Properties: AccountNumber, Balance.
//● Methods: Deposit(double), Withdraw(double), CheckBalance().
//● Include logic to prevent overdraft.
