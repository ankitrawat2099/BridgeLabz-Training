using System;
class RemoveDuplicates{
    static void Main(){
        //take the sting as inpur from user
        Console.Write("Enter a string:");
        string text = Console.ReadLine() ?? "";
        string result = "";

        foreach(char ch in text){
            if(!result.Contains(ch)){
                result += ch;
            }
        }

        Console.WriteLine(result);
    }
}
