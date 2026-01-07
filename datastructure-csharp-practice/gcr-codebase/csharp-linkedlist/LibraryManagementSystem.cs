using System;

class BookNode
{
    public int Id;
    public string Title, Author;
    public bool Available;
    public BookNode? Next, Prev;
    //constructor
    public BookNode(int id, string t, string a)
    {
        Id = id; Title = t; Author = a; Available = true;
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        BookNode? head = null;
//take the book deatils inpyut from user
        Console.Write("Book ID: ");
        int id = int.Parse(Console.ReadLine()!);
        Console.Write("Title: ");
        string t = Console.ReadLine()!;
        Console.Write("Author: ");
        string a = Console.ReadLine()!;

        head = new BookNode(id, t, a);
        Console.WriteLine("Book added & available");
    }
}
