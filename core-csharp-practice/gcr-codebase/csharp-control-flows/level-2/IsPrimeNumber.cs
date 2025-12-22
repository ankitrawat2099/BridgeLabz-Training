using System;

class IsPrimeNumber
{
    static void Main(String[] args)
    {
	//take the numbre as input from user
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
//isprime to check no is greater than 1 or not
        bool isPrime = num > 1;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                isPrime = false;
        }

        Console.WriteLine(isPrime ? "Yes,Prime Number" : "Not a Prime Number");
    }
}
