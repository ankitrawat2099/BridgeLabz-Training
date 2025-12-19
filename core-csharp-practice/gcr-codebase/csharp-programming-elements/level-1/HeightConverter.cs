using System;

class HeightConverter
{
    public static void Main(string[] args)
    {

        // Read height in centimeters from user input
		Console.Write("enter the height in cm: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Convert centimeters to inches
        double inches = heightInCm / 2.54;

        // Calculate feet and remaining inches
        int feet = (int)(inches / 12);
        inches = inches % 12;

        Console.WriteLine($"Your Height in cm is {heightInCm} while in feet is {feet} and inches is {inches}"
        );
    }
}