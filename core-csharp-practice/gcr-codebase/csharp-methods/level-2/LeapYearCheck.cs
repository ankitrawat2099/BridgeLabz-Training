using System;

class LeapYearCheck
{
	//method to check year is leap year or not
    static bool IsLeapYear(int year){
        if (year < 1582){
		return false;}
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }
    static void Main(){
	//take theyear as input from user
        Console.Write("Enter the year:");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsLeapYear(year));
    }
}
