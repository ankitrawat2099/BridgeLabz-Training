using System;

// GPS interface
interface IGPS
{
    void UpdateLocation(string location);
    string GetCurrentLocation();
}

// Abstract vehicle class
abstract class Vehicle
{
    // Private fields for encapsulation
    private int vehicleId;
    private string driverName;

    // Protected rate for child classes
    protected double ratePerKm;

    // Constructor
    protected Vehicle(int id, string driver, double rate)
    {
        vehicleId = id;
        driverName = driver;
        ratePerKm = rate;
    }

    // Abstract method
    public abstract double CalculateFare(double distance);

    // Common method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Vehicle ID : " + vehicleId);
        Console.WriteLine("Driver     : " + driverName);
    }
}

// Car class
class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(int id, string driver)
        : base(id, driver, 15)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }
}

// Bike class
class Bike : Vehicle, IGPS
{
    private string currentLocation;
//constructor
    public Bike(int id, string driver)
        : base(id, driver, 10)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }
}

// Auto class
class Auto : Vehicle, IGPS
{
    private string currentLocation;
//constructor
    public Auto(int id, string driver)
        : base(id, driver, 12)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        // Auto has a base charge
        return (distance * ratePerKm) + 20;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }
}
class RideHailingApplication
{
    static void Main()
    {
        //take the  number of vehicle as input from user
        Console.Write("Enter number of vehicles: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // Array instead of List
        Vehicle[] vehicles = new Vehicle[count];

        // Input loop
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nChoose Vehicle Type");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bike");
            Console.WriteLine("3. Auto");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Vehicle ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Driver Name: ");
            string driver = Console.ReadLine() ?? "";

            if (choice == 1)
                vehicles[i] = new Car(id, driver);
            else if (choice == 2)
                vehicles[i] = new Bike(id, driver);
            else
                vehicles[i] = new Auto(id, driver);
        }
//take the distatnce as input from user
        Console.Write("\nEnter travel distance (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        // Polymorphism demonstration
        Console.WriteLine("\n--- Ride Details ---");
        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].DisplayVehicleDetails();
            Console.WriteLine("Fare Amount: " + vehicles[i].CalculateFare(distance));
            Console.WriteLine();
        }
    }
}
