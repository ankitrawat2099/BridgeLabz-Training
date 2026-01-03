using System;

// Superclass
class Device
{
    public int DeviceId;
    public string Status;

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    // Method to display basic device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID : " + DeviceId);
        Console.WriteLine("Status    : " + Status);
    }
}

// Subclass
class Thermostat : Device
{
    public double TemperatureSetting;

    public Thermostat(int deviceId, string status, double temperature)
        : base(deviceId, status)
    {
        TemperatureSetting = temperature;
    }

    // Overriding method
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting : " + TemperatureSetting + " °C");
    }
}

class SmartHomeDevices
{
    static void Main()
    {
        Console.WriteLine("=== Smart Home Thermostat ===");
// User input for device id
        Console.Write("Enter Device ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
// User input for device status
        Console.Write("Enter Device Status (ON/OFF): ");
        string status = Console.ReadLine()?? "";
// User input for temperature setting
        Console.Write("Enter Temperature Setting: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        // Creating object of subclass
        Thermostat thermostat = new Thermostat(id, status, temp);

        Console.WriteLine("\n--- Device Status ---");
        thermostat.DisplayStatus();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
