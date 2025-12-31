class BankAccount
{
    public string AccountNumber;
    protected string AccountHolder;
    private double Balance;
//parametrised constructor
    public BankAccount(string accNo, string holder, double bal)
    {
        AccountNumber = accNo;
        AccountHolder = holder;
        Balance = bal;
    }
//getter for Balance
    public double GetBalance()
    {
        return Balance;
    }
}
//savings account class inheriting from BankAccount
class SavingsAccount : BankAccount
{
    public SavingsAccount(string accNo, string holder, double bal)
        : base(accNo, holder, bal) { }

    public void ShowDetails()
    {
        Console.WriteLine("Account No: " + AccountNumber);
        Console.WriteLine("Holder: " + AccountHolder); 
    }
}
class BankApp
{
    static void Main(string[] args)
    {
        //take input from user for accont number
        Console.WriteLine("enter account number: ");
        string accNo=Console.ReadLine()?? "";
        //take input from user for account holder name
        Console.WriteLine("enter name: ");
        string accName=Console.ReadLine()?? "";
        //take input from user for balance
        Console.WriteLine("enter balance: ");
        double accBalance=Convert.ToDouble(Console.ReadLine());
        SavingsAccount savings = new SavingsAccount(accNo, accName, accBalance);
        savings.ShowDetails();
        Console.WriteLine("Balance: " + savings.GetBalance());
    }
}