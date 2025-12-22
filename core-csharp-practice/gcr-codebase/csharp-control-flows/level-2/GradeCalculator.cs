using System;

class GradeCalculator
{
    static void Main(String[] args)
    {
        Console.Write("Enter the Physics marks: ");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Chemistry marks: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        Console.Write("Maths marks: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        double avg = (physics + chemistry + maths) / 3.0;
        string grade;
		string remarks;

        if (avg >= 80)
        {
            grade = "A";
            remarks = "Excellent";
        }
        else if (avg >= 70 && avg<=79)
        {
            grade = "B";
            remarks = "very Good";
        }
        else if (avg >= 60 && avg<=69)
        {
            grade = "C";
            remarks = "good";
        }
		else if(avg>=50 && avg<=59){
			 grade = "D";
            remarks = "average";
		}
		else if(avg>=40 && avg<=49){
			 grade = "E";
            remarks = "below avergae";
		}
        else
        {
            grade = "F";
            remarks = "Fail";
        }

        Console.WriteLine($"Average Marks: {avg}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}
