using System;

// Superclass
class Person
{
    public string Name;
    public int Age;
//constructor to initialize person details
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Subclass: Teacher
class Teacher : Person
{
    public string Subject;
//constructor to initialize teacher details
    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }
//method to display teacher details
    public void DisplayRole()
    {
        Console.WriteLine("Role    : Teacher");
        Console.WriteLine("Name    : " + Name);
        Console.WriteLine("Age     : " + Age);
        Console.WriteLine("Subject : " + Subject);
    }
}

// Subclass: Student
class Student : Person
{
    public string Grade;
//constructor to initialize student details
    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }
//method to display student details
    public void DisplayRole()
    {
        Console.WriteLine("Role  : Student");
        Console.WriteLine("Name  : " + Name);
        Console.WriteLine("Age   : " + Age);
        Console.WriteLine("Grade : " + Grade);
    }
}

// Subclass: Staff
class Staff : Person
{
    public string Department;
//constructor to initialize staff details
    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }
//method to display staff details
    public void DisplayRole()
    {
        Console.WriteLine("Role       : Staff");
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
        Console.WriteLine("Department : " + Department);
    }
}

class SchoolSystem
{
    static void Main()
    {
        Console.WriteLine("Choose Role:");
        Console.WriteLine("1 - Teacher");
        Console.WriteLine("2 - Student");
        Console.WriteLine("3 - Staff");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (choice == 1)
        {
            Console.Write("Enter Subject: ");
            string subject = Console.ReadLine();

            Teacher teacher = new Teacher(name, age, subject);
            teacher.DisplayRole();
        }
        else if (choice == 2)
        {
            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();

            Student student = new Student(name, age, grade);
            student.DisplayRole();
        }
        else if (choice == 3)
        {
            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Staff staff = new Staff(name, age, department);
            staff.DisplayRole();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
