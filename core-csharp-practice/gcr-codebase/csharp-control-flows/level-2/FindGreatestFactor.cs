using System;

class FindGreatestFactor
{
    static void Main(String[] args)
    {
	//take number as input from user
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine($"Greatest factor: {greatestFactor}");
    }
}
