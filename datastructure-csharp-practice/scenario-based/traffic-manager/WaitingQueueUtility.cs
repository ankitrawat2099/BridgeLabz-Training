class WaitingQueueUtility
{
    int[] queue;
    int front = 0;
    int rear = -1;
    int size = 0;

    //constructor for setting the capacity of queue
    public WaitingQueueUtility(int capacity)
    {
        queue = new int[capacity];
    }

    public bool IsEmpty() { 
        return size == 0; 
    }
    public bool IsFull()
    {
        return size == queue.Length;
    }
    //method to add vehicle to queue
    public void Enqueue(int data)
    {
        if (IsFull())
        {
            Console.WriteLine("Waiting queue full");
            return;
        }
        queue[++rear] = data;
        size++;
    }
    //method to remove vehicle from queue
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Waiting queue empty");
            return -1;
        }
        size--;
        return queue[front++];
    }
    //method to display waiting vehicle
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No waiting vehicles");
            return;
        }

        Console.Write("Waiting Queue: ");
        for (int i = front; i <= rear; i++)
        {
            Console.Write(queue[i] + " ");
        }
        Console.WriteLine();
    }
}
