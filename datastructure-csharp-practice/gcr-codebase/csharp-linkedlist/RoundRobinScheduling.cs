using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public ProcessNode? Next;
//constructor
    public ProcessNode(int id, int burst)
    {
        ProcessId = id;
        BurstTime = burst;
    }
}

class RoundRobinScheduler
{
    private ProcessNode? head;
    //method to add process
    public void AddProcess(int id, int burst)
    {
        ProcessNode node = new ProcessNode(id, burst);

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next!;

        temp.Next = node;
        node.Next = head;
    }
    //method to execute
    public void Execute(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes available");
            return;
        }

        ProcessNode current = head;
        bool completed;

        do
        {
            completed = true;
            ProcessNode temp = current;

            do
            {
                if (temp.BurstTime > 0)
                {
                    completed = false;

                    if (temp.BurstTime > timeQuantum)
                    {
                        Console.WriteLine($"Process {temp.ProcessId} executed for {timeQuantum}");
                        temp.BurstTime -= timeQuantum;
                    }
                    else
                    {
                        Console.WriteLine($"Process {temp.ProcessId} completed");
                        temp.BurstTime = 0;
                    }
                }
                temp = temp.Next!;
            }
            while (temp != current);

        } while (!completed);
    }
}

class RoundRobinScheduling
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        int choice;

        do
        {
            Console.WriteLine("\n1.Add Process  2.Execute  0.Exit");
            //take choice form user
            choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice == 1)
            {
                Console.Write("Process ID: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Burst Time: ");
                int burst = int.Parse(Console.ReadLine()!);
                scheduler.AddProcess(id, burst);
            }
            else if (choice == 2)
            {
                Console.Write("Time Quantum: ");
                int tq = int.Parse(Console.ReadLine()!);
                scheduler.Execute(tq);
            }

        } while (choice != 0);
    }
}
