using System;

// Interface for reservation feature
interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}

// Abstract base class
abstract class LibraryItem
{
    // Private fields for encapsulation
    private int itemId;
    private string title;
    private string author;

    // Sensitive data kept private
    private string issuedTo;
    private bool available;

    // Constructor
    protected LibraryItem(int id, string title, string author)
    {
        itemId = id;
        this.title = title;
        this.author = author;
        available = true;
    }

    // Abstract method
    public abstract int GetLoanDuration();

    // Common method
    public void DisplayDetails()
    {
        Console.WriteLine("Item ID : " + itemId);
        Console.WriteLine("Title   : " + title);
        Console.WriteLine("Author  : " + author);
    }

    // Helper method for child classes
    protected void IssueItem(string name)
    {
        issuedTo = name;
        available = false;
    }

    protected bool IsItemAvailable()
    {
        return available;
    }
}

// Book class
class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author)
        : base(id, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem(string borrowerName)
    {
        if (IsItemAvailable())
        {
            IssueItem(borrowerName);
            Console.WriteLine("Book issued successfully");
        }
        else
        {
            Console.WriteLine("Book already issued");
        }
    }

    public bool CheckAvailability()
    {
        return IsItemAvailable();
    }
}

// Magazine class
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string title, string author)
        : base(id, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 7;
    }
//method for reserven item
    public void ReserveItem(string borrowerName)
    {
        if (IsItemAvailable())
        {
            IssueItem(borrowerName);
            Console.WriteLine("Magazine issued successfully");
        }
        else
        {
            Console.WriteLine("Magazine not available");
        }
    }

    public bool CheckAvailability()
    {
        return IsItemAvailable();
    }
}

// DVD class
class DVD : LibraryItem, IReservable
{
    //constructor
    public DVD(int id, string title, string author)
        : base(id, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem(string borrowerName)
    {
        if (IsItemAvailable())
        {
            IssueItem(borrowerName);
            Console.WriteLine("DVD issued successfully");
        }
        else
        {
            Console.WriteLine("DVD already issued");
        }
    }
//method to check availability
    public bool CheckAvailability()
    {
        return IsItemAvailable();
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        Console.Write("Enter number of items: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // Array instead of List
        LibraryItem[] items = new LibraryItem[count];

        // Input loop
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\n1.Book  2.Magazine  3.DVD");
            Console.Write("Choose item type: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Item ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            if (choice == 1)
                items[i] = new Book(id, title, author);
            else if (choice == 2)
                items[i] = new Magazine(id, title, author);
            else
                items[i] = new DVD(id, title, author);
        }

        // Display and reserve
        Console.WriteLine("\n--- Library Items ---");
        for (int i = 0; i < items.Length; i++)
        {
            items[i].DisplayDetails();
            Console.WriteLine("Loan Duration: " + items[i].GetLoanDuration() + " days");

            Console.Write("Enter borrower name: ");
            string name = Console.ReadLine();

            IReservable r = (IReservable)items[i];
            r.ReserveItem(name);

            Console.WriteLine();
        }
    }
}
