using System;

class KmToMiles
{
    static void Main()
    {
        double kilometers = 10.8;
		//1km=1.6miles
        double miles = kilometers * 1.6;

        Console.WriteLine("The distance"+kilometers+" km in miles is " + miles);
    }
}
