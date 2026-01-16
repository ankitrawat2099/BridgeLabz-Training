using System;

namespace TrafficManager;

public class RoundaboutLinkedList
{
    private Node head;
    private int capacity;
    private int count;
    //assign the initial capacity of roundabout
    public RoundaboutLinkedList(int capacity)
    {
        this.capacity = capacity;
        count = 0;
    }
    //method to check linkedlist is full or not
    public bool IsFull()
    {
        return count == capacity;
    }
    //method to check likelist is empyt or not
    public bool IsEmpty()
    {
        return head == null;
    }
    //method to add vehicle
    public void AddVehicle(int data)
    {
        if (IsFull())
        {
            Console.WriteLine("Roundabout is FULL");
            return;
        }

        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        count++;
    }
    //method to remove vehicle
    public void RemoveVehicle()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Roundabout is EMPTY");
            return;
        }

        if (head.Next == head)
        {
            head = null;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            head = head.Next;
            temp.Next = head;
        }

        count--;
    }
    //method to displayt linkelist
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No vehicles in roundabout");
            return;
        }

        Node temp = head;
        do
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("(CIRCULAR)");
    }
}
