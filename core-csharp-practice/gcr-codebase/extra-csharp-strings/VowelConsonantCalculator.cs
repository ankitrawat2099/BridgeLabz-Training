using System;
class VowelConsonantCalculator{    
    static void Main(){
        //take theu string as input from user
        Console.Write("Enter a string:");
        string text = Console.ReadLine() ?? "";
        int vowels = 0;
        int consonants = 0;
        foreach(char ch in text){
            char c = char.ToLower(ch);
            if(c >= 'a' && c <= 'z'){
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'){
                    vowels++;}
                else{
                    consonants++;}
            }
        }
        //printin the count of vowelsand consonants
        Console.WriteLine($"Vowels:{vowels}");
        Console.WriteLine($"Consonants: {consonants}");
    }
}
