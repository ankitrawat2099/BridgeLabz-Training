using System;

class TrianglePerimeter
{
//method to find the perimeter of triangele
    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return 5000 / perimeter;
    }

    static void Main(string[] args)
    {
	//taking thse sides from user as input
        Console.Write("Enter side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Rounds need: {CalculatePerimeter(side1, side2, side3)}");
    }
}
