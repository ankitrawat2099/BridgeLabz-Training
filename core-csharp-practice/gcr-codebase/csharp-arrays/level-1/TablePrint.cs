using System;

class TablePrint
{
    static void Main(string[] args)
    {
		//take the number as input form user
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] multiplicationResult = new int[4];

        for (int i = 6; i <= 9; i++)
        {
			//findign the talbel from 6 to 9
            multiplicationResult[i - 6] = number * i;
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}
