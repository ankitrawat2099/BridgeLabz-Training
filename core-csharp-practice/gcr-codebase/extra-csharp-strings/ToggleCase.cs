using System;
class ToggleCase{
    static void Main(){
        //take the string input from user
        Console.Write("Enter a string:");
        string input = Console.ReadLine() ?? "";
        char[] result = new char[input.Length];
        for (int i = 0;i<input.Length;i++){
            char ch = input[i];
            result[i] = char.IsUpper(ch) ? char.ToLower(ch) :char.IsLower(ch) ? char.ToUpper(ch) : ch;
        }
        Console.WriteLine(new string(result));
    }
}
