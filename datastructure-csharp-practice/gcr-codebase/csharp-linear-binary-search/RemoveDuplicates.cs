using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main()
    {
        //take the string input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        //hashset to store unique characters
        HashSet<char> seen = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        foreach (char ch in input)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                result.Append(ch);
            }
        }

        Console.WriteLine("After Removing Duplicates: " + result);
    }
}
