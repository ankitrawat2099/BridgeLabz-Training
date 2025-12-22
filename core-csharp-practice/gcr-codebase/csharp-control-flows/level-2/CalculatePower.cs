using System;

class CalculatePower
{
    static void Main()
    {
	//take the base number from user
        Console.Write("Enter base number: ");
        int number= Convert.ToInt32(Console.ReadLine());
//take the power number for calucaton of power
        Console.Write("Enter power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        long result = 1;

        for (int i = 1; i <= power; i++)
            result *= number;

        Console.WriteLine($"Result is: {result}");
    }
}
