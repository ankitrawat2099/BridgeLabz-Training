using System;

class Division
{
//method to find quotientand remainder
    public static int[] FindRemainderAndQuotient(int number,int divisor){
        return new int[] { number / divisor, number % divisor };
    }

    static void Main(string[] args)
    {
	//take the number as input from user
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
//take the divisor from user
        Console.Write("Enter divisor: ");
        int div = Convert.ToInt32(Console.ReadLine());
        int[] ans = FindRemainderAndQuotient(num, div);
        Console.WriteLine($"Quotient: {ans[0]},Remainder: {ans[1]}");
    }
}
