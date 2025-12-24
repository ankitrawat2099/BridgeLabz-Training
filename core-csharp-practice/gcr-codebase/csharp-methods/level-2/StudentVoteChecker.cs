using System;

class StudentVoteChecker
{
	//method to check student can vote or not
    public static bool CanStudentVote(int age)
    {
        if (age < 0) {
		return false;}
        return age >= 18;
    }

    static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CanStudentVote(ages[i])? "yes,can vote": "Not Eligible");
        }
    }
}
