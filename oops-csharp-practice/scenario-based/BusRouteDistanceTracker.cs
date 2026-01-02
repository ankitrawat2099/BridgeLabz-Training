using System;

class BusRouteDistanceTracker
{
    static void Main()
    {
        // Initialize variable for stop count
        int stopCount = 1;
        //variable to track total distance
        double totalDistance = 0.0;
        // Distance between stops
        double distancePerStop;
        //take the distance between stops as input from user
        Console.Write("Enter distance between each stop (in km): ");
        distancePerStop = Convert.ToDouble(Console.ReadLine());

        while (true)
        {
            totalDistance += distancePerStop;

            Console.WriteLine("\nReached Stop " + stopCount);
            Console.WriteLine("Total distance travelled: " + totalDistance + " km");

            Console.Write("Do you want to get off here? (yes/no): ");
            string choice = Console.ReadLine()?.ToLower()?? "";
            //check if user wants to get off
            if (choice == "yes")
            {
                Console.WriteLine("\nPassenger got off the bus.");
                Console.WriteLine("Final distance travelled: " + totalDistance + " km");
                break;
            }

            stopCount++;
        }
    }
}
