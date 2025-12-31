using System;

class InvoiceGenerator
{
    //method to parse invoice string
    public static string[] ParseInvoice(string input)
    {
        //split tasks using comma
        string[] tasks = input.Split(',');

        return tasks;
    }

    //method to calculate total amount
    public static int GetTotalAmount(string[] tasks)
    {
        int total = 0; 

        for (int i = 0; i < tasks.Length; i++)
        {
            //split task name and amount part
            string[] parts = tasks[i].Split('-');

            if (parts.Length == 2)
            {
                //extract amount part
                string amountPart = parts[1];

                //remove "INR" and spaces
                amountPart = amountPart.Replace("INR", "").Trim();

                int amount = Convert.ToInt32(amountPart);
                total += amount;
            }
        }

        return total;
    }

    static void Main()
    {
		//take the invoice details as input from user
        Console.WriteLine("Enter Invoice Details:");
        string input = Console.ReadLine()?? "";

        string[] tasks = ParseInvoice(input);

        Console.WriteLine("\n--- Invoice Items ---");
        for (int i = 0; i < tasks.Length; i++)
        {
            Console.WriteLine(tasks[i].Trim());
        }

		//print total amount
        Console.WriteLine("\nTotal Invoice Amount: " + GetTotalAmount(tasks) + " INR");
    }
}
