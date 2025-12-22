using System;

class FindFactor
{
    static void Main()
    {
	//take the number as inoput from user
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors are:");
        for (int i = 1; i < number; i++)
        {
		//checkig if a number is factor or not
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
