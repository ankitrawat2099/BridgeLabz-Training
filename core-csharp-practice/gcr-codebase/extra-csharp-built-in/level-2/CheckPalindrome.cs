using System;
class CheckPalindrome
{
    //chekc th string ispalindrome or next
    static bool IsPalindrome(string text){
        int left = 0;
        int right = text.Length - 1;

        while (left < right){
            if (text[left] != text[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
    static void Main(){
        //take the stirng as inpur from  user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine()!;
        Console.WriteLine(IsPalindrome(input) ? "yes,Palindrome" : "Not a Palindrome");
    }
}
