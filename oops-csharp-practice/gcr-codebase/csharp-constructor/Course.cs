using System;
class Course
{
    public string CourseName="";
    public int Duration;
    public double Fee;
    public static string InstituteName = "ABC Institute";
//insatance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine(CourseName + " " + Fee);
    }
//class method to update institute name
    public static void UpdateInstituteName(string name)
    {
        InstituteName = name;
    }

    static void Main(string[] args)
    {
        Course course1 = new Course();
        //taking input from user for course name
        Console.WriteLine("enter the course name: " );
        course1.CourseName = Console.ReadLine()?? "";
        course1.Duration = 3;
        course1.Fee = 1500.00;
        course1.DisplayCourseDetails();

        Course.UpdateInstituteName("XYZ Institute");
        Console.WriteLine("Updated Institute Name: " + Course.InstituteName);
    }
}
