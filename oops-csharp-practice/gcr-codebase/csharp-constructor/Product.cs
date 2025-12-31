using System;
class Product
{
    public string ProductName;
    public double Price;
    public static int TotalProducts;

    public Product(string name, double price)
    {
        ProductName = name;
        Price = price;
        TotalProducts++;
    }
//instance metthod to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine(ProductName + " - " + Price);
    }
//class method to display total products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + TotalProducts);
    }
    static void Main(string[] args)
    {
        Product p1 = new Product("Laptop", 1200.50);
        Product p2 = new Product("Smartphone", 800.00);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
