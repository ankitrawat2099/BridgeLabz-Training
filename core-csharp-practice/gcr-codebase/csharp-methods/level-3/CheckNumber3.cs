using System;
class CheckNumber3
{
    //method to get digits of number
    public static int[] GetDigits(int number)
    {
        int[] digits = new int[number.ToString().Length];
        for (int i=digits.Length-1;i >=0;i--){
            digits[i]=number%10;
            number /= 10;
        }
        return digits;
    }
    //metjod to reverse an array
    public static int[] ReverseArray(int[] array)
    {
        int[] rev = new int[array.Length];
        for (int i = 0;i< array.Length;i++){ 
		rev[i] = array[array.Length - 1 - i];
		}
        return rev;
    }

    //method to check if arrays are equal ir not
    public static bool AreArraysEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++) if (a[i] != b[i]) return false;
        return true;
    }

    //method to check palindrome number
    public static bool IsPalindrome(int number){
        int[] digits = GetDigits(number);
        return AreArraysEqual(digits, ReverseArray(digits));
    }

    //method to check Duck number
    public static bool IsDuck(int number){
        int[] digits = GetDigits(number);
        foreach(int d in digits){
	if (d != 0){
		return true;}
		}
        return false;
    }

    static void Main()
    {
		//take the input from user 
        Console.Write("Enter a number: ");
        int num =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Palindrome: " + IsPalindrome(num));
        Console.WriteLine("Duck Number: " + IsDuck(num));
    }
}
