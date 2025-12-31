using System;


class Account
{
    public string AccountNo;
    public string HolderName;
    public double Balance;
}

class BankService
{
    Account[] accountList = new Account[10];
    int totalAccounts = 0;

    //method for manager to creates account
    public void CreateAccount()
    {
        if (totalAccounts == accountList.Length)
        {
            Console.WriteLine("Maximum account limit reached.");
            return;
        }

        Account acc = new Account();
//take the account numbre as input from user
        Console.Write("Enter Account Number: ");
        acc.AccountNo = Console.ReadLine()?? "";
//take the account name as input from user
        Console.Write("Enter Account Holder Name: ");
        acc.HolderName = Console.ReadLine()?? "";
//take the account balance as input from user
        Console.Write("Enter Opening Balance: ");
        acc.Balance = Convert.ToDouble(Console.ReadLine());

        accountList[totalAccounts] = acc;
        totalAccounts++;

        Console.WriteLine("Account successfully created.");
    }

    // Find account using account number
    public Account FindAccount(string accNo)
    {
        for (int i = 0; i < totalAccounts; i++)
        {
            if (accountList[i].AccountNo == accNo)
                return accountList[i];
        }
        return null;
    }
}

//person class
class Person
{
    protected BankService bank;

    public Person(BankService service)
    {
        bank = service;
    }
}
//customer class inherit person class
class Customer : Person
{
    public Customer(BankService service) : base(service) { }

    public void CustomerMenu()
    {
        Console.Write("Enter your Account Number: ");
        string accNo = Console.ReadLine()?? "";

        Account acc = bank.FindAccount(accNo);

        if (acc == null)
        {
            Console.WriteLine("No account found with this number.");
            return;
        }

        int option;
        do
        {
            Console.WriteLine("\n--- CUSTOMER MENU ---");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Add Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Logout");
            Console.Write("Choose an option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Current Balance: " + acc.Balance);
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());

                    if (deposit > 0)
                    {
                        acc.Balance += deposit;
                        Console.WriteLine("Amount added successfully.");
                    }
                    else
                        Console.WriteLine("Invalid amount.");
                    break;

                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());

                    if (withdraw <= 0)
                        Console.WriteLine("Invalid amount.");
                    else if (withdraw > acc.Balance)
                        Console.WriteLine("Insufficient balance.");
                    else
                    {
                        acc.Balance -= withdraw;
                        Console.WriteLine("Withdrawal successful.");
                    }
                    break;

                case 4:
                    Console.WriteLine("You are logged out.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (option != 4);
    }
}

//manager class inherit person
class Manager : Person
{
    public Manager(BankService service) : base(service) { }

    public void ManagerMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n--- Manager MENU ---");
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. View Account Details");
            Console.WriteLine("3. Logout");
            Console.Write("Choose an option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    bank.CreateAccount();
                    break;

                case 2:
				//take the account number as input from user
                    Console.Write("Enter Account Number: ");
                    string accNo = Console.ReadLine()?? "";

                    Account acc = bank.FindAccount(accNo);

                    if (acc == null)
                        Console.WriteLine("Account not found.");
                    else
                    {
                        Console.WriteLine("Holder Name: " + acc.HolderName);
                        Console.WriteLine("Account Number: " + acc.AccountNo);
                        Console.WriteLine("Balance: " + acc.Balance);
                    }
                    break;

                case 3:
                    Console.WriteLine("Manager logged out.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (option != 3);
    }
}

//main class
class BankSystemManager
{
    static void Main()
    {
        BankService bank = new BankService();
        Manager manager = new Manager(bank);
        Customer customer = new Customer(bank);

        int role;
        do
        {
            Console.WriteLine("\n=== BANK MANAGEMENT SYSTEM ===");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.Write("Select your role: ");

            role = Convert.ToInt32(Console.ReadLine());

            switch (role)
            {
                case 1:
                    manager.ManagerMenu();
                    break;

                case 2:
                    customer.CustomerMenu();
                    break;

                case 3:
                    Console.WriteLine("System closed.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (role != 3);
    }
}