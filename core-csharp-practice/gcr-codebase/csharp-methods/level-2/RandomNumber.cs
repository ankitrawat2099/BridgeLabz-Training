using System;

class RandomNumber
{
	//method to genetate 4 digitnumber
    static int[] Generate4Digit(int size)
    {
        Random rnd = new Random();
        int[] arr = new int[size];

        for (int i=0;i<size;i++)
            arr[i] =rnd.Next(1000, 10000);

        return arr;
    }

//method to find average
    static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0],max=numbers[0],sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }

        return new double[] { (double)sum / numbers.Length, min, max };
    }

    static void Main()
    {
        int[] nums = Generate4Digit(5);
        foreach (int n in nums){
		Console.Write(n + " ");}
        double[] result = FindAverageMinMax(nums);
        Console.WriteLine($"\nAverage: {result[0]}, Min: {result[1]}, Max: {result[2]}");
    }
}
