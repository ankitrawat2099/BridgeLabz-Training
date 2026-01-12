using System;

class SentenceSearch
{
    static void Main()
    {
        string[] sentences =
        {
            "C sharp is powerful","Learning algorithms","Binary search explained"};

        //take the word input from user
        Console.Write("Enter word: ");
        string target = Console.ReadLine();

        foreach (string s in sentences)
        {
            //check if sentence constains target or not
            if (s.Contains(target))
            {
                Console.WriteLine("Found in: " + s);
                break;
            }
            else{
                Console.WriteLine("word not found");
                break;
            }
        }
    }
}
