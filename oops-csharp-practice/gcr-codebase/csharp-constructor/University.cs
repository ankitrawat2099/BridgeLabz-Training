using System;
class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;
//setter for CGPA
    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }
//getter for CGPA
    public double GetCGPA()
    {
        return CGPA;
    }
}
//postgraduate student class inheriting from Student
class PostgraduateStudent : Student
{
    public void ShowName()
    {
        Console.WriteLine(Name);
    }
}

class University
{
    static void Main(string[] args)
    {
        //making object of postgraduate student
        PostgraduateStudent pgStudent = new PostgraduateStudent();
        Console.WriteLine("Enter roll no: ");
        pgStudent.RollNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter cgpa: ");
        pgStudent.SetCGPA(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Roll Number: " + pgStudent.RollNumber);
        Console.WriteLine("CGPA: " + pgStudent.GetCGPA());
    }
}