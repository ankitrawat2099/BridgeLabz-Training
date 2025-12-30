using System;

class Book
{
    private string title;
    private string author;
    private double price;

    //method to set book details
    public void SetDetails(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    //method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title  : " + title);
        Console.WriteLine("Author     : " + author);
        Console.WriteLine("Price      : " + price);
    }
}

class Program
{
    static void Main()
    {
	//make object of book 
        Book b = new Book();
//take the book title from user as input
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine()?? "";
//take the author name as inpur from user
        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine()?? "";
//tkae the price as inpur from user
        Console.Write("Enter Book Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        b.SetDetails(title, author, price);
        b.DisplayDetails();
    }
}
