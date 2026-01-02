using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    //constructor for Employee
    public Employee(string name){
        Name = name;}
}
// Department class to manage employees
class Department
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(string name)
    {
        employees.Add(new Employee(name));
    }
//method to show all employees
    public void ShowEmployees()
    {
        foreach (var emp in employees)
            Console.WriteLine(emp.Name);
    }
}

class Company
{
    // Company has a Department
    private Department department = new Department();

    public void BuildDepartment()
    {
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter employee name: ");
            department.AddEmployee(Console.ReadLine());
        }

        Console.WriteLine("\nEmployees in company:");
        department.ShowEmployees();
    }
}

class CompanyAndDepartment
{
    static void Main()
    {
        Company company = new Company();
        company.BuildDepartment();
    }
}
