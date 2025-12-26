using System;

class CharacterFinder
{
    static void Main()
    {
//take input from the user
        Console.Write("Enter string: "); 
        string text = Console.ReadLine()?? "";
 //convert to char array
        char[] chars = text.ToCharArray();

        Console.WriteLine("Characters:");
        foreach(char c in chars)
            Console.Write(c + " ");
 //using built in function ToCharArray
        Console.WriteLine("\nUsing ToCharArray:");
        foreach (char c in text.ToCharArray())
            Console.Write(c + " ");
    }

    // methjod to conver strring to char array without ToCharArray
    static char[] GetCharacters(string s)
    {
        char[] arr = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
            arr[i] = s[i];

        return arr;
    }
}