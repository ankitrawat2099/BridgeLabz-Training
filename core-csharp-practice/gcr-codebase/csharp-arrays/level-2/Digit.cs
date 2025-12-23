using System;

class Digit
{
    static void Main()
    {
	//take the number as input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digitArray = new int[maxDigit];
        int index = 0;

        while (number != 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digitArray, temp, digitArray.Length);
                digitArray = temp;
            }

            digitArray[index++] = number % 10;
            number /= 10;
        }

        int largestNumber = 0;
		int secondLargestNumber= 0;

        for (int i = 0; i < index; i++)
        {
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

        Console.WriteLine($"Largest: {largestNumber}");
        Console.WriteLine($"Second Largest: {secondLargestNumber}");
    }
}
