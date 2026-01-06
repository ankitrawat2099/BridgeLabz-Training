using System;

// Interface for tax calculation
interface ITaxable
{
    double CalculateTax();
}

// Abstract product class
abstract class Product
{
    private int productId;
    private string productName;
    protected double price;

    protected Product(int id, string name, double price)
    {
        productId = id;
        productName = name;
        this.price = price;
    }

    // Abstract discount method
    public abstract double CalculateDiscount();

    // Display final price
    public void DisplayFinalPrice(double tax)
    {
        double finalPrice = price + tax - CalculateDiscount();
        Console.WriteLine(productName + " Final Price: " + finalPrice);
    }
}

// Electronics product
class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }
//claculate discount method
    public override double CalculateDiscount()
    {
        return price * 0.10;
    }
//method for calculate tax
    public double CalculateTax()
    {
        return price * 0.18;
    }
}

// Clothing product
class Clothing : Product
{
    public Clothing(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.20;
    }
}

class EcommercePlatform
{
    static void Main()
    {
        Product[] products = new Product[2];
//tkae the electronics price as inpur from user
        Console.Write("Enter Electronics Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        products[0] = new Electronics(1, "Laptop", price);
//tkae the cloths price as input from user
        Console.Write("Enter Clothing Price: ");
        price = Convert.ToDouble(Console.ReadLine());
        products[1] = new Clothing(2, "Shirt", price);

        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] is ITaxable)
            {
                ITaxable taxObj = (ITaxable)products[i];
                products[i].DisplayFinalPrice(taxObj.CalculateTax());
            }
            else
            {
                products[i].DisplayFinalPrice(0);
            }
        }
    }
}
