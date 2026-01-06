using System;

// Interface for discount related behavior
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Abstract base class for food items
abstract class FoodItem
{
    // Protected fields for inheritance
    protected string itemName;
    protected double price;
    protected int quantity;

    // Constructor
    protected FoodItem(string name, double price, int quantity)
    {
        itemName = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Abstract method
    public abstract double CalculateTotalPrice();

    // Common method
    public void DisplayItemDetails()
    {
        Console.WriteLine("Item Name : " + itemName);
        Console.WriteLine("Price     : " + price);
        Console.WriteLine("Quantity  : " + quantity);
    }
}

// Veg food item class
class VegItem : FoodItem, IDiscountable
{
    //constructor
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }

    public double ApplyDiscount()
    {
        return 50; // flat discount for veg items
    }

    public string GetDiscountDetails()
    {
        return "Veg item discount applied";
    }
}

// Non-Veg food item class
class NonVegItem : FoodItem, IDiscountable
{
    //constructor
    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        // Extra charge for non-veg items
        return (price * quantity) + 80;
    }

    public double ApplyDiscount()
    {
        return 30;
    }
//method for discount details
    public string GetDiscountDetails()
    {
        return "Non-veg item discount applied";
    }
}

class OnlineFoodDeliverySystem
{
    static void Main()
    {
        Console.Write("Enter number of food items: ");
        int count = Convert.ToInt32(Console.ReadLine());

        // Array instead of List
        FoodItem[] items = new FoodItem[count];

        // Input loop
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nChoose Food Type");
            Console.WriteLine("1. Veg");
            Console.WriteLine("2. Non-Veg");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine()?? "";

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                items[i] = new VegItem(name, price, quantity);
            else
                items[i] = new NonVegItem(name, price, quantity);
        }

        // Processing items using polymorphism
        Console.WriteLine("\n----- Order Summary -----");
        for (int i = 0; i < items.Length; i++)
        {
            items[i].DisplayItemDetails();

            double total = items[i].CalculateTotalPrice();

            IDiscountable discountItem = (IDiscountable)items[i];
            double discount = discountItem.ApplyDiscount();

            Console.WriteLine(discountItem.GetDiscountDetails());
            Console.WriteLine("Final Amount: " + (total - discount));
            Console.WriteLine();
        }
    }
}
