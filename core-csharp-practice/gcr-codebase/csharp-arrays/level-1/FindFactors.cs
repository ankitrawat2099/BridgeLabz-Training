using System;

class FindFactors
{
    static void Main(string[] args)
    {
	//take the number form user as input
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxFactors = 10;
        int[] factors = new int[maxFactors];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
		//checking if number is factor or not
            if (number % i == 0)
            {
                if (index == maxFactors)
                {
				//modify the size to twice
                    maxFactors *= 2;
                    int[] temp = new int[maxFactors];
					//copy the factors array  to temp 
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }
                factors[index] = i;
				index++;
            }
        }

//printing the factors
        for (int i = 0; i < index; i++)
            Console.Write(factors[i] + " ");
    }
}
