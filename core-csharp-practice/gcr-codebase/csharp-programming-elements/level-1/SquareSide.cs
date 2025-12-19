using System;

class SquareSide
{
    public static void Main(string[] args)
    {
        // Read perimeter from user input
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate side of the square
        double side = perimeter / 4;
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}"
        );
    }
}