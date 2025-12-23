using System;

class VoteEligibilty
{
    static void Main(string[] args)
    {
		
        int[] studentAges = new int[10];
//take ages of student form user
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter the age of student: ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < studentAges.Length; i++)
        {
			//checking the voting eleigiblity
            if (studentAges[i] < 0)
                Console.WriteLine("Invalid age");
            else if (studentAges[i] >= 18)
                Console.WriteLine($"The student with the age {studentAges[i]} can vote");
            else
                Console.WriteLine($"The student with the age {studentAges[i]} cannot vote");
        }
    }
}
