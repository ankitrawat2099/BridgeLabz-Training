using System;
class IsPalindrome{
    static void Main(){
        //tkae the string as inpur from user
        Console.Write("Enter a string:");
        string text = Console.ReadLine() ?? "";
        bool isPalindrome = true;
        for (int i = 0;i<text.Length / 2;i++){
            if (text[i] != text[text.Length - i - 1]){
                isPalindrome = false;
                break;
            }
        }
//print the sting is palindrome or not
        Console.WriteLine(isPalindrome ? "yes,Palindrome" : "Not Palindrome");
    }
}
