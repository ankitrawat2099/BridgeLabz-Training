using System;

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
    //constructor for Student
    public Student(string name){
        Name = name;}
//method for student to enroll in a course
    public void EnrollCourse(Course course)
    {
        Console.WriteLine($"{Name} enrolled in {course.Name}");
    }
}

class Professor
{
    public string Name;
    //constructor for Professor
    public Professor(string name){
        Name = name;}
//method for professor to assign to a course
    public void AssignProfessor(Course course)
    {
        Console.WriteLine($"{Name} teaches {course.Name}");
    }
}

class UniversityManagement
{
    static void Main()
    {
        //take the course, student and professor details as input from user
        Console.Write("Enter course name: ");
        Course course = new Course(Console.ReadLine()?? "");

        Console.Write("Enter student name: ");
        Student student = new Student(Console.ReadLine()?? "");

        Console.Write("Enter professor name: ");
        Professor prof = new Professor(Console.ReadLine()?? "");

        student.EnrollCourse(course);
        prof.AssignProfessor(course);
    }
}
