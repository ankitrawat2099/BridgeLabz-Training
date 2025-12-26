using System;
class Lexicographical{
    static void Main(){
        //take the first string as input from user
        Console.Write("Enter first string:");
        string a = Console.ReadLine() ?? "";
        //take thes second string as input from user
        Console.Write("Enter second string:");
        string b = Console.ReadLine() ?? "";
//calculate the min len of both strings
        int len = Math.Min(a.Length, b.Length);
        int result = 0;
        for(int i = 0;i<len;i++){
            if(a[i] != b[i]){
                result = a[i] - b[i];
                break;
            }
        }

        if(result == 0){
            result = a.Length - b.Length;}
//printing the order of strings
        Console.WriteLine(result < 0 ? "First string comes first" :result > 0 ? "Second comes first" : "Equal");
    }
}
