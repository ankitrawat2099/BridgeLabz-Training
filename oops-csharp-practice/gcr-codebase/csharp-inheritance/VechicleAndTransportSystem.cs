using System;

class Vehicle
{
    public int MaxSpeed;
    public string FuelType;
//constructor to initialize vehicle details
    public Vehicle(int speed, string fuel)
    {
        MaxSpeed = speed;
        FuelType = fuel;
    }
//method to display vehicle info
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Speed: {MaxSpeed}, Fuel: {FuelType}");
    }
}

class Car : Vehicle
{
    public int Seats;
//constructor to initialize car details
    public Car(int s, string f, int seats) : base(s, f)
    {
        Seats = seats;
    }
//override display info method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seats: " + Seats);
    }
}

class Truck : Vehicle
{
    public int Payload;
//constructor to initialize truck details
    public Truck(int s, string f, int payload) : base(s, f)
    {
        Payload = payload;
    }
//override display info method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload: " + Payload);
    }
}

class Motorcycle : Vehicle
{
    public bool Sidecar;
//constructor to initialize motorcycle details
    public Motorcycle(int s, string f, bool sidecar) : base(s, f)
    {
        Sidecar = sidecar;
    }
//override display info method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + Sidecar);
    }
}

class VechicleAndTransportSystem
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(180, "Petrol", 5);
        vehicles[1] = new Truck(120, "Diesel", 5000);
        vehicles[2] = new Motorcycle(140, "Petrol", false);

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
            Console.WriteLine("----");
        }
    }
}
