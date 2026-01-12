using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        //take the string input from user
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine();

        StringBuilder builder = new StringBuilder(inputText.Length);

        for (int i = inputText.Length - 1; i >= 0; i--)
        {
            builder.Append(inputText[i]);
        }

        Console.WriteLine("Reversed String: " + builder.ToString());
    }
}
