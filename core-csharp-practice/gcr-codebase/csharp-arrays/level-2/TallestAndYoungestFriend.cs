using System;

class TallestAndYoungestFriend
{
    static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] age= new int[3];
        double[] height= new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {friends[i]}: ");
            age[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of {friends[i]}: ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngest = 0;
        int tallest = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest])
                youngest = i;

            if (height[i] > height[tallest])
                tallest = i;
        }

        Console.WriteLine($"Youngest: {friends[youngest]}");
        Console.WriteLine($"Tallest: {friends[tallest]}");
    }
}
