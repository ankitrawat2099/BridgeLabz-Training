using System;

// Interface for refueling behavior
interface Refuelable
{
    void Refuel();
}

// Superclass
class Vehicle
{
    public string Model;
    public int MaxSpeed;
//constructor to initialize vehicle details
    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }
//method to display basic vehicle info
    public void DisplayBasicInfo()
    {
        Console.WriteLine("Model     : " + Model);
        Console.WriteLine("Max Speed : " + MaxSpeed + " km/h");
    }
}

// Subclass: Electric Vehicle
class ElectricVehicle : Vehicle
{
    public int BatteryPercentage;
//constructor to initialize electric vehicle details
    public ElectricVehicle(string model, int maxSpeed, int battery)
        : base(model, maxSpeed)
    {
        BatteryPercentage = battery;
    }
//method to charge the vehicle
    public void Charge()
    {
        Console.WriteLine("Vehicle is charging...");
        Console.WriteLine("Battery Level : " + BatteryPercentage + "%");
    }
}

// Subclass: Petrol Vehicle (Hybrid Inheritance)
class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelLevel;
//constructor to initialize petrol vehicle details
    public PetrolVehicle(string model, int maxSpeed, int fuel)
        : base(model, maxSpeed)
    {
        FuelLevel = fuel;
    }
//method to refuel the vehicle
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol vehicle...");
        Console.WriteLine("Fuel Level : " + FuelLevel + "%");
    }
}

class VehicleManagementSystem
{
    static void Main()
    {
        //take vehicle type choice as input from user
        Console.WriteLine("Choose Vehicle Type:");
        Console.WriteLine("1 - Electric Vehicle");
        Console.WriteLine("2 - Petrol Vehicle");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Vehicle Model: ");
        string model = Console.ReadLine();

        Console.Write("Enter Max Speed: ");
        int speed = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter Battery Percentage: ");
            int battery = int.Parse(Console.ReadLine());

            ElectricVehicle ev = new ElectricVehicle(model, speed, battery);

            Console.WriteLine("\n--- Electric Vehicle Details ---");
            ev.DisplayBasicInfo();
            ev.Charge();
        }
        else if (choice == 2)
        {
            Console.Write("Enter Fuel Level Percentage: ");
            int fuel = int.Parse(Console.ReadLine());

            PetrolVehicle pv = new PetrolVehicle(model, speed, fuel);

            Console.WriteLine("\n--- Petrol Vehicle Details ---");
            pv.DisplayBasicInfo();
            pv.Refuel();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
