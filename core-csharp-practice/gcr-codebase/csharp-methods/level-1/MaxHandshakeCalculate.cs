using System;

class MaxHandshakeCalculate
{
	//method to find the handshakes number
    static int NoOfHandshake(int studentNumber)
    {
        return (studentNumber * (studentNumber- 1)) / 2;
    }

    static void Main(string[] args)
    {
		//takeing no of students as input form user
        Console.Write("Enter number of student: ");
        int num = Convert.ToInt32(Console.ReadLine());
//printing the handshakes number
        Console.WriteLine($"Maximum: {NoOfHandshake(num)}");
		
    }
}

