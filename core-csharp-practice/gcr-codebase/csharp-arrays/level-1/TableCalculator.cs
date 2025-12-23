using System;

class TableCalculator
{
    static void Main(string[] args)
    {
		//take the number form user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
// array for storing the table
        int[] result = new int[10];

        for (int i = 1;i<=result.Length; i++)
        {
			//stroirng the tabale in the array
            result[i - 1] = number * i;
            Console.WriteLine($"{number} * {i} = {result[i - 1]}");
        }
    }
}
