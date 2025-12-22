using System;

class CanVote
{
    static void Main()
    {
	//taking the age from user
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
//checking the user age for vote
        if (age >= 18)
            Console.WriteLine($"The person's age is {age} and can vote.");
        else
            Console.WriteLine($"The person's age is {age} and cannot vote.");
    }
}
