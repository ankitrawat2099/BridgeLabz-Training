using System;

class Employee
{
    public int EmployeeID;
    protected string Department;
    private double Salary;

    // Constructor to initialize protected field
    public Employee(int id, string dept, double salary)
    {
        EmployeeID = id;
        Department = dept; 
        Salary = salary;
    }
//setter for Salary
    public void SetSalary(double salary)
    {
        Salary = salary;
    }
//getter for Salary
    public double GetSalary()
    {
        return Salary;
    }
}
//manager class inheriting from Employee
class Manager : Employee
{
    public Manager(int id, string dept, double salary)
        : base(id, dept, salary) { }

    public void DisplayInfo()
    {
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Department: " + Department); 
    }
}

class EmployeeRecord
{
    static void Main()
    {
        Console.WriteLine("enter the employee ID:");
        int empId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the department:");
        string empDept=Console.ReadLine()?? "";
        Console.WriteLine("enter the salary:");
        double empSalary=Convert.ToDouble(Console.ReadLine());
        Manager mgr = new Manager(empId, empDept, empSalary);

        mgr.DisplayInfo();
        Console.WriteLine("Salary: " + mgr.GetSalary());
    }
}
