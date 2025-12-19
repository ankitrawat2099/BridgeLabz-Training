using System;
class AgeCalculator
{
    static void Main(String[] args)
    {
        int birthYear = 2000;
        int currentYear = 2024;
//subtract the current age year -birht year
        int age = currentYear - birthYear;

        Console.WriteLine("Harry's age in 2024 is " + age);
    }
}
