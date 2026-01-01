using System;
//product class
class Product
{
    public static double Discount = 10;

    public string ProductName;
    public double Price;
    public int Quantity;
    public readonly int ProductID;
//consturctor to initialize product details
    public Product(string productName, double price, int quantity, int productId)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productId;
    }
//static method to update discount
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }
//method to display product details
    public void DisplayProduct(object obj)
    {
        if (obj is Product)
        {
            Console.WriteLine($"Product: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Discount: {Discount}%");
        }
    }

    static void Main()
    {
        //take the product details from user
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine()?? "";
        //take the price from user
        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
//take the quantity from user
        Console.Write("Enter Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());
//take the product id from user
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product p = new Product(name, price, qty, id);
        p.DisplayProduct(p);
    }
}
