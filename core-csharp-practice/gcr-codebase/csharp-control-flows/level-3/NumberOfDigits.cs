using System;

class NumberOfDigits
{
    static void Main(String[] args)
    {
	//take the number as input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (number != 0)
        {
            number = number/10;
            count++;
        }

        Console.WriteLine($"Number of digits: {count}");
    }
}
