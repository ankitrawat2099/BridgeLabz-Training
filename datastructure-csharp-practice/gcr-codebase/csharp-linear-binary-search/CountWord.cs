using System;
using System.IO;

class CountWord
{
    static void Main()
    {
      string path = "C:\\Users\\admin\\Downloads\\strings\\demo.txt";

        //take the word to search from user
        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();

        int count = 0;

        StreamReader reader = new StreamReader(path);
        
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string w in words)
                {
                    if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }
        

        Console.WriteLine("Word Occurrences: " + count);
    }
}
