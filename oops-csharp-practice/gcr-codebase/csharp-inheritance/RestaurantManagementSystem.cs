using System;

// Interface (multiple behavior)
interface Worker
{
    void PerformDuties();
}

// Superclass
class Person
{
    public string Name;
    public int Id;

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
//method to display person info
    public void DisplayPersonInfo()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("ID   : " + Id);
    }
}

// Subclass: Chef
class Chef : Person, Worker
{
    public string Specialty;
//constructor to initialize chef details
    public Chef(string name, int id, string specialty)
        : base(name, id)
    {
        Specialty = specialty;
    }
//method to perform chef duties
    public void PerformDuties()
    {
        Console.WriteLine("Role      : Chef");
        Console.WriteLine("Specialty : " + Specialty);
        Console.WriteLine("Duty      : Preparing and cooking food");
    }
}

// Subclass: Waiter
class Waiter : Person, Worker
{
    public int TableCount;
//  constructor to initialize waiter details
    public Waiter(string name, int id, int tableCount)
        : base(name, id)
    {
        TableCount = tableCount;
    }
//method to perform waiter duties
    public void PerformDuties()
    {
        Console.WriteLine("Role       : Waiter");
        Console.WriteLine("Tables     : " + TableCount);
        Console.WriteLine("Duty       : Serving customers and taking orders");
    }
}

class RestaurantManagementSystem
{
    static void Main()
    {
        //take role choice as input from user
        Console.WriteLine("Choose Role:");
        Console.WriteLine("1 - Chef");
        Console.WriteLine("2 - Waiter");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Worker worker;

        if (choice == 1)
        {
            Console.Write("Enter Cooking Specialty: ");
            string specialty = Console.ReadLine();

            worker = new Chef(name, id, specialty);
        }
        else if (choice == 2)
        {
            Console.Write("Enter Number of Tables Assigned: ");
            int tables = int.Parse(Console.ReadLine());

            worker = new Waiter(name, id, tables);
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        Console.WriteLine("\n--- Employee Details ---");
        ((Person)worker).DisplayPersonInfo();
        worker.PerformDuties();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
