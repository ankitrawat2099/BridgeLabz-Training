using System;

class NaturalSum
{
//method to calcualt the sum 
    static int Sum(int n)
    {
        int total = 0;
        for (int i = 1; i <= n; i++)
            total += i;
        return total;
    }

    static void Main()
    {
	//take the number as input from user
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Sum(n));
    }
}
