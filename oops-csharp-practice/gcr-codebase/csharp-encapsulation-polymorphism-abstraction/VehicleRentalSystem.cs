using System;

// Insurance related interface
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Abstract Vehicle class
abstract class Vehicle
{
    // Encapsulated fields
    private string vehicleNumber;
    private string vehicleType;
    protected double rentalRate;

    // Constructor to initialize vehicle data
    protected Vehicle(string number, string type, double rate)
    {
        vehicleNumber = number;
        vehicleType = type;
        rentalRate = rate;
    }

    // Getter methods
    public string GetVehicleType()
    {
        return vehicleType;
    }

    // Abstract method for rental cost
    public abstract double CalculateRentalCost(int days);
}

// Car class
class Car : Vehicle, IInsurable
{
    public Car(string number, double rate)
        : base(number, "Car", rate)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public string GetInsuranceDetails()
    {
        return "Car insurance applied";
    }
}

// Bike class
class Bike : Vehicle, IInsurable
{
    //constructor for bike
    public Bike(string number, double rate)
        : base(number, "Bike", rate)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 200;
    }

    public string GetInsuranceDetails()
    {
        return "Bike insurance applied";
    }
}

// Truck class
class Truck : Vehicle, IInsurable
{
    public Truck(string number, double rate)
        : base(number, "Truck", rate)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 1.5;
    }
//method for calcuate insrurnace
    public double CalculateInsurance()
    {
        return 1000;
    }
//method to get insurance detials
    public string GetInsuranceDetails()
    {
        return "Truck insurance applied";
    }
}

// Main class
class VehicleRentalSystem
{
    static void Main()
    {
        // Taking number of vehicles
        Console.Write("Enter number of vehicles: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // Creating array of Vehicle references
        Vehicle[] vehicles = new Vehicle[count];

        // Input loop
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nVehicle " + (i + 1));

            Console.Write("Enter vehicle type (Car/Bike/Truck): ");
            string type = Console.ReadLine() ?? "";

            Console.Write("Enter vehicle number: ");
            string number = Console.ReadLine()?? "";

            Console.Write("Enter daily rental rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            // Object creation based on type
            if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                vehicles[i] = new Car(number, rate);
            }
            else if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                vehicles[i] = new Bike(number, rate);
            }
            else
            {
                vehicles[i] = new Truck(number, rate);
            }
        }

        // Rental duration
        Console.Write("\nEnter number of rental days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        // Processing vehicles using polymorphism
        Console.WriteLine("\n--- Rental Details ---");
        for (int i = 0; i < vehicles.Length; i++)
        {
            double rent = vehicles[i].CalculateRentalCost(days);

            IInsurable insuranceObj = (IInsurable)vehicles[i];
            double insurance = insuranceObj.CalculateInsurance();

            Console.WriteLine(
                vehicles[i].GetVehicleType() +
                " | Rent: " + rent +
                " | Insurance: " + insurance
            );
        }
    }
}
