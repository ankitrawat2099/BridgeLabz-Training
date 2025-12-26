using System;
class CountStrings{
    static void Main(){
        //take the text inputr fom user
        Console.Write("Enter the string:");
        string text = Console.ReadLine() ?? "";
        //tkae the subStringsubstring input from user
        Console.Write("Enter the substring:");
        string subString = Console.ReadLine() ?? "";
        int count = 0;
        for (int i = 0;i<=text.Length - subString.Length;i++){
            int match = 0;
            for(int j =0;j<subString.Length;j++){
                if(text[i + j] == subString[j])
                    match++;
            }
            if(match == subString.Length){
                count++;}
        }

        Console.WriteLine(count);
    }
}
