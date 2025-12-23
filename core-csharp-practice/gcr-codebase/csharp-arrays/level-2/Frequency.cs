using System;

class Frequency
{
    static void Main()
    {
	//take the number as input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//array to store the frequency 
        int[] frequency = new int[10];
        while (number != 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
                Console.WriteLine($"Digit {i} occurs {frequency[i]} times");
        }
    }
}
