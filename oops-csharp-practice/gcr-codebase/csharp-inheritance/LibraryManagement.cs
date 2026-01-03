using System;

class Book
{
    public string Title;
    public int Year;
//constructor to initialize book details
    public Book(string title, int year)
    {
        Title = title;
        Year = year;
    }
}
//author class inheriting from book
class Author : Book
{
    public string Name;
    public string Bio;
//constructor to initialize author and book details
    public Author(string title, int year, string name, string bio)
        : base(title, year)
    {
        Name = name;
        Bio = bio;
    }
//method to display author and book details
    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title} ({Year})");
        Console.WriteLine($"Author: {Name}");
        Console.WriteLine($"Bio: {Bio}");
    }
}

class LibraryManagement
{
    static void Main()
    {
        //take the author name as inpur from user
        Console.Write("Enter author name: ");
        string name=Console.ReadLine()?? "";
        //take the author bio as input from user
        Console.Write("Enter author bio: ");
        string bio=Console.ReadLine()?? "";
        //take book title as input from user
        Console.Write("Enter book title: ");
        string title=Console.ReadLine()?? "";
        //take book publication year as input from user
        Console.Write("Enter publication year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        Author a = new Author(title, year, name, bio);
        a.DisplayInfo();
    }
}
