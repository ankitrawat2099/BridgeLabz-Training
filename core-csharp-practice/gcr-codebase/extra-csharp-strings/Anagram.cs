using System;
class Anagram
{
    static void Main(){
        //tale two strings as input from user
        Console.Write("Enter first string:");
        string a = Console.ReadLine() ?? "";
        Console.Write("Enter second string:");
        string b = Console.ReadLine() ?? "";

        if (a.Length != b.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] count = new int[256];
        foreach(char c in a){
            count[c]++;}
        foreach(char c in b){
         count[c]--;}

        foreach(int n in count){
            if(n != 0)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }
        }

        Console.WriteLine("Anagrams");
    }
}
