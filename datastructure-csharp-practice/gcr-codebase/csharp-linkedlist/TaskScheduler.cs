using System;

class TaskNode
{
    public int Id, Priority;
    public string Name, DueDate;
    public TaskNode? Next;
//constructor
    public TaskNode(int id, string n, int p, string d)
    {
        Id = id; Name = n; Priority = p; DueDate = d;
    }
}

class TaskCircularList
{
    private TaskNode? head;
    //method to add
    public void Add(TaskNode node)
    {
        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next!;

        temp.Next = node;
        node.Next = head;
    }

    public void Display()
    {
        if (head == null) return;

        TaskNode temp = head;
        do
        {
            Console.WriteLine($"{temp.Id} | {temp.Name} | {temp.Priority}");
            temp = temp.Next!;
        } while (temp != head);
    }
}

class TaskScheduler
{
    static void Main()
    {
        TaskCircularList list = new TaskCircularList();
        int ch;
        do
        {
            Console.WriteLine("\n1.Add Task 2.Display 0.Exit");
            //take the choice as input from user
            ch = int.Parse(Console.ReadLine() ?? "0");

            if (ch == 1)
            {
                Console.Write("Id: "); int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: "); string n = Console.ReadLine()!;
                Console.Write("Priority: "); int p = int.Parse(Console.ReadLine()!);
                Console.Write("Due Date: "); string d = Console.ReadLine()!;
                list.Add(new TaskNode(id, n, p, d));
            }
            else if (ch == 2) list.Display();
        }
        while (ch != 0);
    }
}
