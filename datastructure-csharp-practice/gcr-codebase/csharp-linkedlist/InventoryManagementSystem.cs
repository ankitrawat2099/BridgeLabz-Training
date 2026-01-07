using System;

class ItemNode
{
    public int Id, Qty;
    public string Name;
    public double Price;
    public ItemNode? Next;
    //consttructor
    public ItemNode(int id, string n, int q, double p)
    {
        Id = id; Name = n; Qty = q; Price = p;
    }
}

class InventoryList
{
    private ItemNode? head;
    //method to add
    public void Add(ItemNode node)
    {
        node.Next = head;
        head = node;
    }
    //method to display total value
    public void DisplayTotalValue()
    {
        double total = 0;
        for (ItemNode? t = head; t != null; t = t.Next)
            total += t.Price * t.Qty;

        Console.WriteLine("Total Inventory Value = " + total);
    }
}

class InventoryManagementSystem
{
    static void Main()
    {
        InventoryList list = new InventoryList();
        int ch;
        do
        {
            Console.WriteLine("\n1.Add Item 2.Total Value 0.Exit");
            //take the choice from user
            ch = int.Parse(Console.ReadLine() ?? "0");

            if (ch == 1)
            {
                Console.Write("Id: "); int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: "); string n = Console.ReadLine()!;
                Console.Write("Qty: "); int q = int.Parse(Console.ReadLine()!);
                Console.Write("Price: "); double p = double.Parse(Console.ReadLine()!);
                list.Add(new ItemNode(id, n, q, p));
            }
            else if (ch == 2) list.DisplayTotalValue();
        }
        while (ch != 0);
    }
}
