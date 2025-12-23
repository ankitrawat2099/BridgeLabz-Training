using System;

class DigitArray
{
    static void Main()
    {
	//take the nunmber as input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digitArray = new int[maxDigit];
        int index = 0;
//storring the digits in the array unitl the index
        while (number != 0 && index < maxDigit)
        {
            digitArray[index++] = number % 10;
            number /= 10;
        }

        int largestNumber = 0;
		int secondLargestNumber = 0;

        for (int i = 0; i < index; i++)
        {
		//calculating the largest and the second largest number
            if (digitArray[i] > largestNumber)
            {
                secondLargestNumber = largestNumber;
                largestNumber = digitArray[i];
            }
            else if (digitArray[i] > secondLargestNumber && digitArray[i] != largestNumber)
            {
                secondLargestNumber = digitArray[i];
            }
        }

        Console.WriteLine($"Largest = {largestNumber}");
        Console.WriteLine($"Second Largest = {secondLargestNumber}");
    }
}
