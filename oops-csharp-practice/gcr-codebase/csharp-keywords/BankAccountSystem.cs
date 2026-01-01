using System;

class BankAccount
{
    public static string BankName = "HDFC Bank";
    private static int totalAccounts = 0;

    public string AccountHolderName;
    public readonly int AccountNumber;

    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        totalAccounts++;
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is BankAccount)
        {
            Console.WriteLine($"Bank: {BankName}, Name: {AccountHolderName}, Account No: {AccountNumber}");
        }
    }
}
class BankAccountSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the name of account1:");
        string name1 = Console.ReadLine()?? "";
        Console.WriteLine("enter the account number of account1:");
        int accNum1 = Convert.ToInt32(Console.ReadLine());
        BankAccount account1 = new BankAccount(name1, accNum1);
        Console.WriteLine("enter the name of account1:");
        string name2 = Console.ReadLine()?? "";
        Console.WriteLine("enter the account number of account1:");
        int accNum2 = Convert.ToInt32(Console.ReadLine());
        BankAccount account2 = new BankAccount(name2, accNum2);

        account1.DisplayDetails(account1);
        account2.DisplayDetails(account2);

        BankAccount.GetTotalAccounts();
    }
}