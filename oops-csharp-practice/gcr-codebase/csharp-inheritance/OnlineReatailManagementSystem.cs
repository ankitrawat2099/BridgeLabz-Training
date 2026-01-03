using System;

class Order
{
    public int OrderId;
    public string OrderDate;
//constructor to initialize order details
    public Order(int id, string date)
    {
        OrderId = id;
        OrderDate = date;
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber;
//constructor to initialize shipped order details
    public ShippedOrder(int id, string date, string track)
        : base(id, date)
    {
        TrackingNumber = track;
    }
}

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;
//constructor to initialize delivered order details
    public DeliveredOrder(int id, string date, string track, string delivery)
        : base(id, date, track)
    {
        DeliveryDate = delivery;
    }
//method to get order status
    public void GetOrderStatus()
    {
        Console.WriteLine("Order Delivered on " + DeliveryDate);
    }
}

class OnlineReatailManagementSystem
{
    static void Main()
    {
        //user input for order track no
        Console.WriteLine("enter tracking number:");
        string trackNo=Console.ReadLine()?? "";
        //user input for delivery date
        Console.WriteLine("enter delivery date:");
        string deliveryDate=Console.ReadLine()?? "";
        //user input for order id and date
        Console.WriteLine("enter order id:");
        int orderId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter order date:");
        string orderDate=Console.ReadLine()?? "";

        DeliveredOrder o = new DeliveredOrder(orderId, orderDate, trackNo, deliveryDate);
        o.GetOrderStatus();
    }
}
