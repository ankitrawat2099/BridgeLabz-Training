using System;
using System.Collections.Generic;

class BookItem
{
    // Book details
    public string Title ;
    public string Author ;
// Constructor for BookItem
    public BookItem(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class LibraryUnit
{
    // Library details
    public string LibraryName ;
    private List<BookItem> books = new List<BookItem>();

    public LibraryUnit(string name)
    {
        LibraryName = name;
    }

    public void AddBook(BookItem book)
    {
        books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine($"\nBooks in {LibraryName}:");
        foreach (var book in books)
            Console.WriteLine($"- {book.Title} by {book.Author}");
    }
}

class Library
{
    static void Main()
    {
        //take the book details as input from user
        Console.WriteLine("enter the title of first book");
        string title1=Console.ReadLine()?? "";
         Console.WriteLine("enter the author of first book");
         string author1=Console.ReadLine()?? "";
          Console.WriteLine("enter the title of second book");
        string title2=Console.ReadLine()?? "";
         Console.WriteLine("enter the author of second book");
            string author2=Console.ReadLine()?? "";
        BookItem b1 = new BookItem(title1, author1);
        BookItem b2 = new BookItem(title2, author2);

        LibraryUnit lib1 = new LibraryUnit("City Library");
        LibraryUnit lib2 = new LibraryUnit("College Library");

        lib1.AddBook(b1);
        lib2.AddBook(b1);
        lib2.AddBook(b2);

        lib1.ShowBooks();
        lib2.ShowBooks();
    }
}
