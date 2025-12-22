using System;

class FizzBuzz
{
    static void Main(String[] args)
    {
	//take the number as input from user
        Console.Write("Enter a positive number: ");
        int num = Convert.ToInt32(Console.ReadLine());
//checking for fizzbuzz ,fizz and Buzz
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
