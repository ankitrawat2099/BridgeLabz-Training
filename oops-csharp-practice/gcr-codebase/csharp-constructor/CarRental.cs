using System;
class CarRental
{
    public string CustomerName;
    public string CarModel;
    public int RentalDays;
    public double TotalCost;
//parametrised constructor
    public CarRental(string customer, string model, int days)
    {
        CustomerName = customer;
        CarModel = model;
        RentalDays = days;
        CalculateCost();
    }
//methjod to calculate total cost
    private void CalculateCost()
    {
        TotalCost = RentalDays * 1000;
    }
    static void Main()
    {
        CarRental rental = new CarRental("Ankit", "Toyota fortuner", 5);
        Console.WriteLine("Customer Name: " + rental.CustomerName);
        Console.WriteLine("Car Model: " + rental.CarModel);
        Console.WriteLine("Rental Days: " + rental.RentalDays);
        Console.WriteLine("Total Cost: $" + rental.TotalCost);
    }
}
