using System;

class Student
{
    public static string UniversityName = "AKTU";
    private static int totalStudents = 0;

    public string Name;
    public string Grade;
    public readonly int RollNumber;
//constructor to initialize student details
    public Student(string name, int roll, string grade)
    {
        this.Name = name;
        this.RollNumber = roll;
        this.Grade = grade;
        totalStudents++;
    }
//static method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }
//method to display student details
    public void DisplayStudent(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll No: {RollNumber}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    static void Main()
    {

        //take the student form usre
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine()?? "";
//take the rollnum from user
        Console.Write("Enter Roll Number: ");
        int roll = Convert.ToInt32(Console.ReadLine());
//take the grade form user
        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine()?? "";

        Student s = new Student(name, roll, grade);
        s.DisplayStudent(s);
        DisplayTotalStudents();
    }
}
