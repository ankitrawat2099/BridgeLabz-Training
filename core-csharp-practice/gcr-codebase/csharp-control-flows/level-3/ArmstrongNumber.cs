using System;

class ArmstrongNumber
{
    static void Main()
    {
	//take the number as inpur form user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0)
        {
            int rem = originalNumber % 10;
            sum += rem * rem * rem;
            originalNumber /= 10;
        }

        if (sum == number)
            Console.WriteLine($"{number} is an Armstrong Number");
        else
            Console.WriteLine($"{number} is not an Armstrong Number");
    }
}
