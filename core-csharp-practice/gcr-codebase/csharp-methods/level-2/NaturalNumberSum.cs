using System;

class NaturalNumberSum
{
	//metjhod to find the recursive sum
    static int RecursiveSum(int n)
    {
        if (n == 0) {
		return 0;}
		
        return n + RecursiveSum(n - 1);
    }
//method to find formjula sum
    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main()
    {
	//take the number as input from user
        Console.Write("Enter natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());
//check number is natura or not
        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }
        Console.WriteLine($"Recursive:{RecursiveSum(n)}");
        Console.WriteLine($"Formula:{FormulaSum(n)}");
        Console.WriteLine(RecursiveSum(n)== FormulaSum(n));
    }
}
