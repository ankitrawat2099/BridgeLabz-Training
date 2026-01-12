using System;

class FirstNegativeNumber
{
    static void Main()
    {
        //numbers array 
        int[] numbers = { 3, 5, 7, -2, 9 };

        foreach (int n in numbers)
        {
            if (n < 0)
            {
                Console.WriteLine("First Negative: " + n);
                break;
            }
        }
    }
}
