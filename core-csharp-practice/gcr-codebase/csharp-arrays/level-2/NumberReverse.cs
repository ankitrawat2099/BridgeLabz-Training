using System;

class NumberReverse
{
    static void Main()
    {
	//take the number input from user 
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
//temp to store the number 
        int temp = number;
		int count = 0;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digitArray = new int[count];
		int i=0;
        while(i < count)
        {
            digitArray[i] = number % 10;
            number /= 10;
			i++;
        }
//reverse number
        Console.Write("Reverse: ");
        for (i = 0; i < count; i++)
            Console.Write(digitArray[i]);
    }
}
