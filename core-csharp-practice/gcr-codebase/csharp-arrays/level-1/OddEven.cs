using System;

class OddEven
{
    static void Main(string[] args)
    {
		//take the natural number as input from user
        Console.Write("Enter the natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//check if number is natural or not
        if (number <= 0)
        {
            Console.Error.WriteLine("Invalid input");
            Environment.Exit(0);
        }

        int[] even = new int[number / 2 + 1];
        int[] odd = new int[number / 2 + 1];
        int evenIndex = 0;
		int	oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
			//cheking for odd and even number
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }
//printing the odd number
        Console.WriteLine("Odd Number:");
        for (int i = 0; i < oddIndex; i++){
		Console.Write(odd[i] + " ");
		}
//printting the even nubmer
        Console.WriteLine("\nEven Number:");
        for (int i = 0; i < evenIndex; i++){
			Console.Write(even[i] + " ");
    }}
}
