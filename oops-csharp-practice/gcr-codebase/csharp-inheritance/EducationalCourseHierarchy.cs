using System;

// Base class
class Course
{
    public string CourseName;
    public int Duration;

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Course Name : " + CourseName);
        Console.WriteLine("Duration    : " + Duration + " hours");
    }
}

// First level subclass
class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;
//constructor to initialize online course details
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
//override display details method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Platform    : " + Platform);
        Console.WriteLine("Recorded    : " + (IsRecorded ? "Yes" : "No"));
    }
}

// Second level subclass
class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;
//constructor to initialize paid online course details
    public PaidOnlineCourse(
        string courseName,
        int duration,
        string platform,
        bool isRecorded,
        double fee,
        double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }
//override display details method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Course Fee  : ₹" + Fee);
        Console.WriteLine("Discount   : " + Discount + "%");
        Console.WriteLine("Final Fee  : ₹" + (Fee - (Fee * Discount / 100)));
    }
}

class EducationalCourseHierarchy
{
    static void Main()
    {
        Console.WriteLine("=== Paid Online Course Details ===");
//take the course name as input from user
        Console.Write("Enter Course Name: ");
        string name = Console.ReadLine()?? "";
//take the course duration as input from user
        Console.Write("Enter Duration (hours): ");
        int duration = Convert.ToInt32(Console.ReadLine());
    //take the platform name as input from user
        Console.Write("Enter Platform: ");
        string platform = Console.ReadLine()?? "";
//take whether the course is recorded or not as input from user
        Console.Write("Is the course recorded? (true/false): ");
        bool recorded = Convert.ToBoolean(Console.ReadLine());
//take the course fee as input from user
        Console.Write("Enter Course Fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());
//take the discount percentage as input from user
        Console.Write("Enter Discount (%): ");
        double discount = Convert.ToDouble(Console.ReadLine());

        PaidOnlineCourse course = new PaidOnlineCourse(
            name, duration, platform, recorded, fee, discount
        );

        Console.WriteLine("\n--- Course Information ---");
        course.DisplayDetails();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
