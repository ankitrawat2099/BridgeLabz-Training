using System;

class DistributeChocolate
{
	//method to find chocolates and remaining chocolates
    static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] {number/divisor,number%divisor};
    }

    static void Main()
    {
	//take the number of chocolates from user as iunput
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());
//take the number of children form user as input
        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());
//ans array to store remainder and quotient
        int[] ans = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Chocolates: {ans[0]},Remaining chocolates:{ans[1]}");
    }
}
