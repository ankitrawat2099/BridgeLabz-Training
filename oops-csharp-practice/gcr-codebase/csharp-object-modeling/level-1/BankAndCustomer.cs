using System;
// Bank class to manage accounts
class BankCenter
{
    public void OpenAccount(ClientUser user)
    {
        Console.WriteLine($"Account opened for {user.Name}");
    }
}
// ClientUser class to represent a bank customer
class ClientUser
{
    public string Name { get; }
    private double balance;
//constructor for ClientUser
    public ClientUser(string name, double amount)
    {
        Name = name;
        balance = amount;
    }
//methjod to view balance
    public void ViewBalance()
    {
        Console.WriteLine($"Balance: ₹{balance}");
    }
}

class BankAndCustomer
{
    static void Main()
    {
        //take the customer details as input from user
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine()?? "";

        Console.Write("Enter initial balance: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        ClientUser customer = new ClientUser(name, amount);
        BankCenter bank = new BankCenter();

        bank.OpenAccount(customer);
        customer.ViewBalance();
    }
}
