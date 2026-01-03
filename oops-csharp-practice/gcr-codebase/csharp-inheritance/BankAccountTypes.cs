using System;

// Superclass
class BankAccount
{
    public int AccountNumber;
    public double Balance;
//constructor to initialize bank account details
    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
//method to display basic account details
    public void DisplayBasicDetails()
    {
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Balance        : ₹" + Balance);
    }
}

// Subclass: Savings Account
class SavingsAccount : BankAccount
{
    public double InterestRate;
//constructor to initialize savings account details
    public SavingsAccount(int accNo, double balance, double interestRate)
        : base(accNo, balance)
    {
        InterestRate = interestRate;
    }
//method to display savings account type details
    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type   : Savings Account");
        Console.WriteLine("Interest Rate : " + InterestRate + "%");
    }
}

// Subclass: Checking Account
class CheckingAccount : BankAccount
{
    public int WithdrawalLimit;
//constructor to initialize checking account details
    public CheckingAccount(int accNo, double balance, int limit)
        : base(accNo, balance)
    {
        WithdrawalLimit = limit;
    }
//method to display checking account type details
    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type      : Checking Account");
        Console.WriteLine("Withdrawal Limit : ₹" + WithdrawalLimit);
    }
}

// Subclass: Fixed Deposit Account
class FixedDepositAccount : BankAccount
{
    public int Tenure; // in years
//constructor to initialize fixed deposit account details
    public FixedDepositAccount(int accNo, double balance, int tenure)
        : base(accNo, balance)
    {
        Tenure = tenure;
    }
//method to display fixed deposit account type details
    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type : Fixed Deposit Account");
        Console.WriteLine("Tenure      : " + Tenure + " years");
    }
}

class BankAccountTypes
{
    static void Main()
    {
        //take account type choice as input from user
        Console.WriteLine("Select Account Type:");
        Console.WriteLine("1 - Savings Account");
        Console.WriteLine("2 - Checking Account");
        Console.WriteLine("3 - Fixed Deposit Account");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Account Number: ");
        int accNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Balance: ");
        double balance = double.Parse(Console.ReadLine());

        Console.WriteLine();

        if (choice == 1)
        {
            Console.Write("Enter Interest Rate (%): ");
            double rate = double.Parse(Console.ReadLine());

            SavingsAccount sa = new SavingsAccount(accNo, balance, rate);
            sa.DisplayBasicDetails();
            sa.DisplayAccountType();
        }
        else if (choice == 2)
        {
            Console.Write("Enter Withdrawal Limit: ");
            int limit = int.Parse(Console.ReadLine());

            CheckingAccount ca = new CheckingAccount(accNo, balance, limit);
            ca.DisplayBasicDetails();
            ca.DisplayAccountType();
        }
        else if (choice == 3)
        {
            Console.Write("Enter Tenure (years): ");
            int tenure = int.Parse(Console.ReadLine());

            FixedDepositAccount fd = new FixedDepositAccount(accNo, balance, tenure);
            fd.DisplayBasicDetails();
            fd.DisplayAccountType();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
