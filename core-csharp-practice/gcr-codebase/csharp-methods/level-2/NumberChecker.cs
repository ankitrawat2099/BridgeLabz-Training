using System;

class NumberChecker
{
	//method to chck nunmber
    static bool IsPositive(int num){
	return num >= 0;}
    static bool IsEven(int num){
return 	num % 2 == 0;}

    static int Compare(int a, int b)
    {
        if (a > b){
		return 1;}
        if (a == b){
		return 0;}
		
        return -1;
    }

    static void Main()
    {
		//take input form user
        int[] numbers = new int[5];
        for (int i=0;i<numbers.Length;i++)
        {
            Console.Write($"Enter number: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());

            if (IsPositive(numbers[i])){
                Console.WriteLine(IsEven(numbers[i]) ? "Positive Even" : "Positive Odd");}
            else{
                Console.WriteLine("Negative");}
        }

        int ans = Compare(numbers[0], numbers[4]);
        Console.WriteLine(ans == 1 ? "First > Last" :ans == 0 ? "First = Last" : "First < Last");
    }
}
