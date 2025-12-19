using System;

class AreaOfTriangle
{
    public static void Main(string[] args)
    {
        // Read base and height from user input (in inches)
        double baseInInches = Convert.ToDouble(Console.ReadLine());
        double heightInInches = Convert.ToDouble(Console.ReadLine());

        // Calculate area in square inches
        double areaInSquareInches = 0.5 * baseInInches * heightInInches;

        // Convert the  area to square centimeters
        double areaInSquareCm = areaInSquareInches * Math.Pow(2.54, 2);
        Console.WriteLine($"The area of the triangle in square inches is {areaInSquareInches} and in square centimeters is {areaInSquareCm}"
        );
    }
}