using System;

class WordReplace
{
    static void Main(){
        //take the sentence, old word and new word as input from user
        Console.Write("Enter a sentence:");
        string sentence = Console.ReadLine() ?? "";
        Console.Write("Enter the word to be replaced:");
        string oldWord = Console.ReadLine() ?? "";
        Console.Write("Enter the new word:");
        string newWord = Console.ReadLine() ?? "";
        string result = "";
        string temp = "";

        foreach(char ch in sentence + " "){
            if(ch == ' '){
                result += temp == oldWord ? newWord : temp;
                result += " ";
                temp = "";
            }
            else{
                temp += ch;
            }
        }

        Console.WriteLine(result.Trim());
    }
}
