using System;

class YoungestAndTallestFriend
{
    static void Main(String[] args)
    {
	//take the age and height of amar from user
        Console.Write("Amar age & height: ");
        int ageAmar = Convert.ToInt32(Console.ReadLine());
        int heightAmar = Convert.ToInt32(Console.ReadLine());
		
//take the age and height of akbar from user
        Console.Write("Akbar age & height: ");
        int ageAkbar = Convert.ToInt32(Console.ReadLine());
        int heightAkbar = Convert.ToInt32(Console.ReadLine());
		
//take the age and height of anthony from user
        Console.Write("Anthony age & height: ");
        int ageAnthony = Convert.ToInt32(Console.ReadLine());
        int heightAnthony = Convert.ToInt32(Console.ReadLine());
//check the youngest among them
        if (ageAmar < ageAkbar && ageAmar < ageAnthony)
            Console.WriteLine("Amar is youngest");
        else if (ageAkbar < ageAmar && ageAkbar < ageAnthony)
            Console.WriteLine("Akbar is youngest");
        else
            Console.WriteLine("Anthony is youngest");
//check the tallest among them
        if (heightAmar > heightAkbar && heightAmar > heightAnthony)
            Console.WriteLine("Amar is tallest");
        else if (heightAkbar > heightAnthony && heightAkbar > heightAnthony)
            Console.WriteLine("Akbar is tallest");
        else
            Console.WriteLine("Anthony is tallest");
    }
}
