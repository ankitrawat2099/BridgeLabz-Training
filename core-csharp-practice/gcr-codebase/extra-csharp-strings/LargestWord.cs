using System;
class LargestWord{
    static void Main(){
        //take the word as input from user
        Console.Write("Enter text:");
        string str = Console.ReadLine() ?? "";
        string word = "";
        string longest = "";
        //adding space at end of string
        str+=" ";
        for(int i=0;i<str.Length;i++){
            char ch=str[i];
            if(ch == ' '){
                if(word.Length> longest.Length)
                    longest = word;
                word = "";
            }
            else
            {
                word += ch;
            }
        }
        Console.WriteLine(longest);
    }
}
