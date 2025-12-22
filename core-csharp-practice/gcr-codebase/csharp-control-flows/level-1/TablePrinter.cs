using System;

class TablePrinter
{
    static void Main(String[] args)
    {
	//take the number as input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//iterate from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
