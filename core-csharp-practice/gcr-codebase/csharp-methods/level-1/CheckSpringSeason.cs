using System;

class CheckSpringSeason
{
//method to check is spring season 
    static bool IsSeason(int month, int day)
    {
        return (month == 3 && day >= 20) ||(month > 3 && month < 6) ||(month == 6 && day <= 20);
    }

    static void Main()
    {
	//take the month as input from user
        int month = Convert.ToInt32(Console.ReadLine());
		//take the day as input from user
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsSeason(month,day));
    }
}
