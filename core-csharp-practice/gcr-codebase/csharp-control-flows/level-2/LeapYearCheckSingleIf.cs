using System;

class LeapYearCheckSingleIf
{
    static void Main(String[] args)
    {
	//take the year from user
        Console.Write("Enter the  year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            Console.WriteLine($"{year} is a Leap Year");
        else
            Console.WriteLine($"{year} is not a Leap Year");
    }
}
