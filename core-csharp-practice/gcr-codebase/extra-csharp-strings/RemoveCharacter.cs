using System;
class RemoveCharacter{
    static void Main(){
        //tkae the string and character to remove as input from user
        Console.Write("Enter a string:");
        string text = Console.ReadLine() ?? "";
        Console.Write("Enter a character to remove:");
        char remove = Console.ReadLine()?[0] ?? '\0';
        string result = "";

        foreach(char ch in text){
            if(ch != remove)
                result += ch;
        }

        Console.WriteLine(result);
    }
}
