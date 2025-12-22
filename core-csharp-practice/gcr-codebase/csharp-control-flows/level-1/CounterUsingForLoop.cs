using System;

class CounterUsingForLoop
{
    static void Main()
    {
		//enter the number
        Console.Write("Enter countdown start number: ");
        int counter = Convert.ToInt32(Console.ReadLine());
//checking while the number is greater than 1
        for(int i=counter;i>=1;i--)
        {
            Console.WriteLine(i);
            
        }
    }
}
