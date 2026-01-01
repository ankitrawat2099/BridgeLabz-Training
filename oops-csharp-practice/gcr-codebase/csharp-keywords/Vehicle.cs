using System;

class Vehicle
{
    public static double RegistrationFee = 5000;

    public string OwnerName;
    public string VehicleType;
    public readonly string RegistrationNumber;
//constructor to initialize vehicle details
    public Vehicle(string owner, string type, string regNo)
    {
        this.OwnerName = owner;
        this.VehicleType = type;
        this.RegistrationNumber = regNo;
    }
//method to display vehicle details
    public void DisplayVehicle(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine($"Owner: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Registration No: {RegistrationNumber}");
            Console.WriteLine($"Fee: {RegistrationFee}");
        }
    }

    static void Main()
    {
        //take vehicle details from user
        Console.Write("Enter Owner Name: ");
        string owner = Console.ReadLine()?? "";
//take vehicle type from user
        Console.Write("Enter Vehicle Type: ");
        string type = Console.ReadLine()?? "";
//take registration number from user
        Console.Write("Enter Registration Number: ");
        string reg = Console.ReadLine()?? "";

        Vehicle v = new Vehicle(owner, type, reg);
        v.DisplayVehicle(v);
    }
}
