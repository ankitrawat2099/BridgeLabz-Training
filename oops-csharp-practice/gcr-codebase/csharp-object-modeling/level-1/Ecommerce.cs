using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    //constructor for Product
    public Product(string name){
        Name = name;}
}

class Order
{
    //list to hold products in the order
    public List<Product> Products = new List<Product>();
}

class Customer
{
    public string Name;
    //constructor for Customer
    public Customer(string name){
        Name = name;}
//method for customer to place an order
    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"{Name} placed an order with {order.Products.Count} products");
    }
}

class Ecommerce
{
    static void Main()
    {
        //take the customer details as input from user
        Console.Write("Enter customer name: ");
        Customer customer = new Customer(Console.ReadLine()?? "");

        Order order = new Order();

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine()?? "");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter product name: ");
            order.Products.Add(new Product(Console.ReadLine()?? ""));
        }

        customer.PlaceOrder(order);
    }
}
