using System;
using System.Collections.Generic;

class Course
{
    public string Name;
    //constructor for Course
    public Course(string name){
         Name = name;}
}

class Student
{
    public string Name;
    //list to hold enrolled courses
    private List<Course> courses = new List<Course>();

    public Student(string name){
         Name = name;}
//method to enroll in a course
    public void Enroll(Course course)
    {
        courses.Add(course);
    }
//method to show all enrolled courses
    public void ShowCourses()
    {
        Console.WriteLine($"{Name}'s Courses:");
        foreach (var c in courses)
            Console.WriteLine(c.Name);
    }
}

class SchoolAndStudent
{
    static void Main()
    {
        //take the student details as input from user
        Console.Write("Enter student name: ");
        Student student = new Student(Console.ReadLine()?? "");

        Console.Write("Enter number of courses: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter course name: ");
            student.Enroll(new Course(Console.ReadLine()?? ""));
        }

        student.ShowCourses();
    }
}
