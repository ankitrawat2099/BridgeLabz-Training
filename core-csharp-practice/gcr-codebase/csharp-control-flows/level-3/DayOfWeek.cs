using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
	//month 
        int m = Convert.ToInt32(Console.ReadLine());
		//day
        int d =  Convert.ToInt32(Console.ReadLine());
		//year
        int y = Convert.ToInt32(Console.ReadLine());
//using the formula
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine($"Day of week: {d0}");
    }
}
