using System;

class Employee
{
    public static string CompanyName = "Capgemini";
    private static int totalEmployees = 0;

    public string Name;
    public string Designation;
    public readonly int Id;
// Constructor to initialize employee details
    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }
// Static method to display total employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }
// Method to display employee details
    public void DisplayEmployee(object obj)
    {
        if (obj is Employee)
        {
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Designation: {Designation}");
        }
    }

    static void Main()
    {
        // Input employee details
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine()?? "";
// Handle null input
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
// Handle null input
        Console.Write("Enter Designation: ");
        string desig = Console.ReadLine()?? "";

        Employee emp = new Employee(name, id, desig);
        emp.DisplayEmployee(emp);

        DisplayTotalEmployees();
    }
}
