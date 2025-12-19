using System;

class PenDistributor
{
    static void Main(String[] args)
    {
        int totalPens = 14;
        int totalStudents = 3;
// count the no of pen each student
        int pensPerStudent = totalPens / totalStudents;
		//count the remaining pens
        int remainingPens = totalPens % totalStudents;

        Console.WriteLine("The Pen Per Student is " + pensPerStudent +" and the remaining pen not distributed is " + remainingPens);
    }
}
