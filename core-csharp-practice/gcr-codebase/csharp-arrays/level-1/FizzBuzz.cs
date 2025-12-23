using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
		//take the number as input form usr
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//cheking the number is poistive or not
        if (number <= 0)
        {
            Console.WriteLine("Invalid input");
            Environment.Exit(0);
        }

        string[] results = new string[number + 1];

        for (int i = 1; i <= number; i++)
        {
			//checking for 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }

//printing the result
        for (int i = 1; i <= number; i++)
            Console.WriteLine($"Position {i} = {results[i]}");
    }
}
