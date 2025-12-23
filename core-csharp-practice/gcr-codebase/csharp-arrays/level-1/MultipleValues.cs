using System;

class MultipleValues
{
    static void Main(string[] args)
    {
        double[] arr = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
			
			//taking the nunmber as input from user
            Console.Write("Enter the number: ");
            double userEntry = Convert.ToDouble(Console.ReadLine());
// check if the number is less than zero or not and also for index
            if (userEntry <= 0 || index == 10)
                break;

            arr[index++] = userEntry;
        }
//calculatin the total 
        for (int i = 0; i < index; i++){
            total += arr[i];
			}

        Console.WriteLine($"Total is: {total}");
    }
}
