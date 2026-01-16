using System;

namespace TrafficManager;
public class TrafficMenu : IRoundaboutManager
{
    private RoundaboutLinkedList roundabout;
    private WaitingQueueUtility queue;
    //constructor to assign the capacity of roundabout and queue
    public TrafficMenu(int roundCap, int queueCap)
    {
        roundabout = new RoundaboutLinkedList(roundCap);
        queue = new WaitingQueueUtility(queueCap);
    }
    //method to add vehicle
    public void EnterVehicle(int vehicleNo)
    {
        if (!roundabout.IsFull())
        {
            roundabout.AddVehicle(vehicleNo);
            Console.WriteLine("Vehicle entered roundabout");
        }
        else
        {
            queue.Enqueue(vehicleNo);
            Console.WriteLine("Vehicle added to waiting queue");
        }
    }

    // method for  exit cehicle
    public void ExitVehicle()
    {
        roundabout.RemoveVehicle();

        if (!queue.IsEmpty())
        {
            int v = queue.Dequeue();
            roundabout.AddVehicle(v);
            Console.WriteLine("Vehicle moved from queue to roundabout");
        }
    }
    //method for showing traffic status
    public void ShowTrafficStatus()
    {
        Console.WriteLine("\n--- Traffic Status ---");
        roundabout.Display();
        queue.Display();
    }
}
