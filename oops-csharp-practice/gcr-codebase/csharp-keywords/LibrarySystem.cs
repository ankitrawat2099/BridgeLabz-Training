using System;

class Book
{
    public static string LibraryName = "Central Library";

    public string Title;
    public string Author;
    public readonly string ISBN;
// Constructor to initialize book details
    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }
    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + LibraryName);
    }
// Method to display book details
    public void DisplayBook(object obj)
    {
        if (obj is Book)
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
class LibrarySystem{
    static void Main()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine()?? "";

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine()?? "";

        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine()?? "";

        Book book = new Book(title, author, isbn);
        Book.DisplayLibraryName();
        book.DisplayBook(book);
    }}

