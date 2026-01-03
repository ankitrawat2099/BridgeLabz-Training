using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;
//constructor to initialize employee details
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
    }
}
//manager class inheriting from employee
class Manager : Employee
{
    public int TeamSize;
//constructor to initialize manager details
    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}
//developer class inheriting from employee
class Developer : Employee
{
    public string Language;
//constructor to initialize developer details
    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary)
    {
        Language = language;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Language: " + Language);
    }
}
//intern class inheriting from employee
class Intern : Employee
{
    public string Duration;
//constructor to initialize intern details
    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary)
    {
        Duration = duration;
    }
//override display details method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + Duration);
    }
}

class EmployeeManagementSystem
{
    static void Main()
    {
        //user input for employee type
        Console.WriteLine("1-Manager 2-Developer 3-Intern");
        int choice = Convert.ToInt32(Console.ReadLine());   
        //user input for employee name
        Console.Write("Name: ");
        string name = Console.ReadLine()?? "";
        //user input for employee id 
        Console.Write("Id: ");
        int id =Convert.ToInt32(Console.ReadLine());
        //user input for employee salary
        Console.Write("Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp;

        if (choice == 1)
        {
            Console.Write("Team Size: ");
            emp = new Manager(name, id, salary, Convert.ToInt32(Console.ReadLine()));
        }
        else if (choice == 2)
        {
            Console.Write("Programming Language: ");
            emp = new Developer(name, id, salary, Console.ReadLine()?? "");
        }
        else
        {
            Console.Write("Internship Duration: ");
            emp = new Intern(name, id, salary, Console.ReadLine()?? "");
        }

        emp.DisplayDetails();
    }
}
