using System;

class NumberChecker
{
//method to check number
    static int CheckNumber(int number)
    {
        if(number > 0){
		return 1;}
        if (number < 0){
		return -1;
		}
        return 0;
    }

    static void Main()
    {
	//taking the number as inout from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{CheckNumber(number)}");
    }
}
