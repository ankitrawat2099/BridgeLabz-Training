using System;

// Loan related interface
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// Abstract BankAccount class
abstract class BankAccount
{
    // Private data for security
    private string accountNumber;
    private string holderName;

    // Protected balance for child classes
    protected double balance;

    // Constructor to initialize account
    protected BankAccount(string accNo, string name, double bal)
    {
        accountNumber = accNo;
        holderName = name;
        balance = bal;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        balance = balance + amount;
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
        }
    }

    // Abstract interest calculation
    public abstract double CalculateInterest();
}

// Savings Account class
class SavingsAccount : BankAccount, ILoanable
{
    //consturctor
    public SavingsAccount(string accNo, string name, double bal)
        : base(accNo, name, bal)
    {
    }

    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan request submitted for Savings Account");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5;
    }
}

// Current Account class
class CurrentAccount : BankAccount
{
    public CurrentAccount(string accNo, string name, double bal)
        : base(accNo, name, bal)
    {
    }

    public override double CalculateInterest()
    {
        return balance * 0.01;
    }
}

// Main execution class
class BankingSystem
{
    static void Main()
    {
        Console.Write("Enter number of accounts: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // Creating array instead of List
        BankAccount[] accounts = new BankAccount[count];

        // Taking input
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nAccount " + (i + 1));
//take account type as input from user
            Console.Write("Enter account type (Savings/Current): ");
            string type = Console.ReadLine() ?? "";
//take the account balance as inpur from user
            Console.Write("Enter balance: ");
            double bal = Convert.ToDouble(Console.ReadLine());

            // Object creation based on account type
            if (type.Equals("Savings", StringComparison.OrdinalIgnoreCase))
            {
                accounts[i] = new SavingsAccount("S" + i, "User", bal);
            }
            else
            {
                accounts[i] = new CurrentAccount("C" + i, "User", bal);
            }
        }

        // Display interest details
        Console.WriteLine("\n--- Interest Details ---");
        for (int i = 0; i < accounts.Length; i++)
        {
            double interest = accounts[i].CalculateInterest();
            Console.WriteLine("Account " + (i + 1) + " Interest: " + interest);
        }
    }
}
