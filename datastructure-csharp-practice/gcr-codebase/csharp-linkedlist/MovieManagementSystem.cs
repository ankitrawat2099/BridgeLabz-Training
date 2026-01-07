using System;

class MovieNode
{
    public string Title, Director;
    public int Year;
    public double Rating;
    public MovieNode? Next, Prev;
    //constructor 
    public MovieNode(string t, string d, int y, double r)
    {
        Title = t; Director = d; Year = y; Rating = r;
    }
}

class MovieList
{
    private MovieNode? head, tail;
    //method to add at end
    public void AddEnd(MovieNode node)
    {
        if (head == null)
            head = tail = node;
        else
        {
            tail!.Next = node;
            node.Prev = tail;
            tail = node;
        }
    }
//method to remove by title
    public void RemoveByTitle(string title)
    {
        MovieNode? temp = head;
        while (temp != null && temp.Title != title)
            temp = temp.Next;

        if (temp == null) { Console.WriteLine("Not found"); return; }

        if (temp == head) head = temp.Next;
        if (temp == tail) tail = temp.Prev;
        if (temp.Prev != null) temp.Prev.Next = temp.Next;
        if (temp.Next != null) temp.Next.Prev = temp.Prev;

        Console.WriteLine("Movie removed");
    }
//method to display forward
    public void DisplayForward()
    {
        for (MovieNode? t = head; t != null; t = t.Next)
            Console.WriteLine($"{t.Title} | {t.Director} | {t.Year} | {t.Rating}");
    }

    public void DisplayReverse()
    {
        for (MovieNode? t = tail; t != null; t = t.Prev)
            Console.WriteLine($"{t.Title} | {t.Director} | {t.Year} | {t.Rating}");
    }
}

class MovieManagementSystem
{
    static void Main()
    {
        MovieList list = new MovieList();
        int ch;
        do
        {
            Console.WriteLine("\n1.Add 2.Remove 3.Display 4.Reverse 0.Exit");
            //take input from user for choice
            ch = int.Parse(Console.ReadLine() ?? "0");

            if (ch == 1)
            {
                Console.Write("Title: "); string t = Console.ReadLine()!;
                Console.Write("Director: "); string d = Console.ReadLine()!;
                Console.Write("Year: "); int y = int.Parse(Console.ReadLine()!);
                Console.Write("Rating: "); double r = double.Parse(Console.ReadLine()!);
                list.AddEnd(new MovieNode(t, d, y, r));
            }
            else if (ch == 2)
            {
                Console.Write("Title: ");
                list.RemoveByTitle(Console.ReadLine()!);
            }
            else if (ch == 3) list.DisplayForward();
            else if (ch == 4) list.DisplayReverse();
        }
        while (ch != 0);
    }
}
