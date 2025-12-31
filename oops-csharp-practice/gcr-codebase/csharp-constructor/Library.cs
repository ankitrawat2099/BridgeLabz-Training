using System;
class Book
{
    public string ISBN="";
    protected string Title="";
    private string Author="";
//setter for Author
    public void SetAuthor(string author)
    {
        Author = author;
    }
//getter for Author
    public string GetAuthor()
    {
        return Author;
    }
}
//ebook class inheriting from Book
class EBook : Book
{
    public void Display()
    {
        Console.WriteLine(ISBN + " " + Title);
    }
}
class Library
{
    static void Main(string[] args)
    {
        //making object of EBook
        EBook ebook = new EBook();
        Console.WriteLine("Enter ISBN: ");
        ebook.ISBN = Console.ReadLine()?? "";
        Console.WriteLine("Enter Author Name: ");
        ebook.SetAuthor(Console.ReadLine()?? "");
        ebook.Display();
        Console.WriteLine("Author: " + ebook.GetAuthor());
    }
}
