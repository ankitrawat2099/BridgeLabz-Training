using System;
//interface
interface IDepartment
{
    void AssignDepartment(string dept);
    string GetDepartment();
}
//abstract class 
abstract class Employee : IDepartment
{
    private int employeeId;
    private string name;
    protected double baseSalary;
    private string department;
//constructor for employee
    protected Employee(int id, string name, double salary)
    {
        employeeId = id;
        this.name = name;
        baseSalary = salary;
    }
//method to assign department
    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartment(){
        return  department;
        }

    public abstract double CalculateSalary();
//method to dispaly
    public void Display()
    {
        Console.WriteLine($"ID:{employeeId} Name:{name} Dept:{department} Salary:{CalculateSalary()}");
    }
}

class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary) { }

    public override double CalculateSalary(){
        return baseSalary;}
}

class PartTimeEmployee : Employee
{
    private int hours;
    private double rate;
//constructor
    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        this.hours = hours;
        this.rate = rate;
    }

    public override double CalculateSalary(){
        return hours * rate;}
}

class EmployeeManagementSystem
{
    static void Main()
    {
        Employee[] employees = new Employee[2];
//take the full time emplyee detaiuls
        Console.Write("Enter FullTimeEmployee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine()?? "";
        Console.Write("Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        employees[0] = new FullTimeEmployee(id, name, salary);
        employees[0].AssignDepartment("IT");
//take the part time emplyee details
        Console.Write("Enter PartTimeEmployee ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        name = Console.ReadLine()?? "";
        Console.Write("Hours: ");
        int hrs = Convert.ToInt32(Console.ReadLine());
        Console.Write("Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        employees[1] = new PartTimeEmployee(id, name, hrs, rate);
        employees[1].AssignDepartment("HR");

        for (int i = 0; i < employees.Length; i++)
            employees[i].Display();
    }
}
