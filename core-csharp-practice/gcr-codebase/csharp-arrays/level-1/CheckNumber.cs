using System;

class CheckNumber
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
//enter the numbers form user
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enterthe number: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
//chekding the nyunmer is positive negatrive and enven odd
        for(int i=0;i<arr.Length;i++)
        {
            if (arr[i]> 0)
            {
                Console.WriteLine(i % 2 == 0 ? $"{arr[i]} is Positive Even" : $"{arr[i]} is Positive Odd");
            }
            else if (arr[i] < 0)
            {
                Console.WriteLine($"{arr[i]} is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
		//chekding the last elemetn with first element

        if (arr[0] == arr[arr.Length-1])
            Console.WriteLine("First and Last elements are Equal");
        else if (arr[0] > arr[arr.Length-1])
            Console.WriteLine("First element is Greater");
        else
            Console.WriteLine("Last element is Greater");
    }
}
