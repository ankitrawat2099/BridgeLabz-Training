using System;

class CheckHarshadNumber
{
    static void Main(String[] args)
    {
	//take the number as inpur from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//copy the number for chekcing
        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number = number/10;
        }

        if (originalNumber % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
