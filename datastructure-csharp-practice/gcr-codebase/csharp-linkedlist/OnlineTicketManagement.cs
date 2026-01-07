using System;

class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public TicketNode? Next;
    //constructor
    public TicketNode(int id, string name)
    {
        TicketId = id;
        CustomerName = name;
    }
}

class TicketSystem
{
    private TicketNode? last;
    //method to book ticket
    public void BookTicket(int id, string name)
    {
        TicketNode node = new TicketNode(id, name);

        if (last == null)
        {
            last = node;
            node.Next = node;
        }
        else
        {
            node.Next = last.Next;
            last.Next = node;
            last = node;
        }
    }
    //method to display tickets
    public void DisplayTickets()
    {
        if (last == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode temp = last.Next!;
        do
        {
            Console.WriteLine($"{temp.TicketId} - {temp.CustomerName}");
            temp = temp.Next!;
        }
        while (temp != last.Next);
    }
}

class OnlineTicketManagement
{
    static void Main()
    {
        TicketSystem system = new TicketSystem();
        int choice;

        do
        {
            Console.WriteLine("\n1.Book Ticket  2.Display Tickets  0.Exit");
            //take input from user
            choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice == 1)
            {
                Console.Write("Ticket ID: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Customer Name: ");
                string name = Console.ReadLine()!;
                system.BookTicket(id, name);
            }
            else if (choice == 2)
                system.DisplayTickets();

        } while (choice != 0);
    }
}
