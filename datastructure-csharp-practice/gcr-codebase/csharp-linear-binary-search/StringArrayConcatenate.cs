using System;
using System.Text;

class StringArrayConcatenate
{
    static void Main()
    {
        //take the number of string input from user
        Console.Write("Enter number of strings: ");
        int count = Convert.ToInt32(Console.ReadLine());
        //string builder to append strings
        StringBuilder combined = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter string " + (i + 1) + ": ");
            combined.Append(Console.ReadLine());
        }

        Console.WriteLine("Final String: " + combined);
    }
}
