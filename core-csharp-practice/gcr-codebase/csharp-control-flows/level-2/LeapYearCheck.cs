using System;

class LeapYearCheck
{
    static void Main(String[] args)
    {
	//take the year as input from user to check if it is leap year or not
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
//checing the year is greater than 1582 or not
        if (year >= 1582)
        {
            if (year % 400 == 0)
                Console.WriteLine($"{year} is a Leap Year");
            else if (year % 100 == 0)
                Console.WriteLine($"{year} is not a Leap Year");
            else if (year % 4 == 0)
                Console.WriteLine($"{year} is a Leap Year");
            else
                Console.WriteLine($"{year} is not a Leap Year");
        }
        else
        {
            Console.WriteLine("Year must be 1582 or later");
        }
    }
}
