using System;
class Vehicle
{
    public string OwnerName="";
    public string VehicleType="";
    public static double RegistrationFee = 5000;
//instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine(OwnerName + " - " + VehicleType);
    }
//class method to update registration fee
    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle();
        //takeing input from user for owner name and vehicle type
        Console.WriteLine("enter owner name: ");
        
        vehicle1.OwnerName = Console.ReadLine()?? "";
        Console.WriteLine("enter vechicle type: ");
        vehicle1.VehicleType = Console.ReadLine()?? "";
        vehicle1.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(6000);
        Console.WriteLine("Updated Registration Fee: " + Vehicle.RegistrationFee);
    }
}
