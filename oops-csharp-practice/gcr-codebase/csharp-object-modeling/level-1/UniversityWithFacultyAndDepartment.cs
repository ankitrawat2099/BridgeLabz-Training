using System;
using System.Collections.Generic;

class Faculty
{
    public string Name;
    //constructor for Faculty
    public Faculty(string name){
        Name = name;}
}

class Department
{
    public string Name;
    //constructor for Department
    public Department(string name){
        Name = name;}
}

class University
{//lists to hold faculties and departments
    public List<Department> Departments = new List<Department>();
    public List<Faculty> Faculties = new List<Faculty>();
}

class UniversityWithFacultyAndDepartment
{
    static void Main()
    {
        University uni = new University();
//take the university details as input from user
        Console.Write("Enter department name: ");
        uni.Departments.Add(new Department(Console.ReadLine()?? ""));

        Console.Write("Enter faculty name: ");
        uni.Faculties.Add(new Faculty(Console.ReadLine()?? ""));

        Console.WriteLine("University created successfully");
    }
}
