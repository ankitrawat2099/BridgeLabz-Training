using System;

class SmallestAndLargestNumber
{
//method to find the largest and the smallest number
    public static int[] FindSmallestAndLargest(int number1,int number2,int number3){
        int smallNum = Math.Min(number1, Math.Min(number2, number3));
        int largestNum = Math.Max(number1, Math.Max(number2, number3));
        return new int[] {smallNum,largestNum};
    }


    static void Main(string[] args)
    {
	//take the input from user
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
//storing the result in ans array
        int[] ans = FindSmallestAndLargest(number1, number2, number3);
        Console.WriteLine($"Smallest Number:{ans[0]}, LargestNumber: {ans[1]}");
    }
}
