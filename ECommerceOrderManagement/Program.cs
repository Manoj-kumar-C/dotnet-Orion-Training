using System;
using System.Collections.Generic;

// Base Product class
public abstract class Product
{
    public string ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string productId, string name, decimal price)
    {
        ProductID = productId;
        Name = name;
        Price = price;
    }

    public virtual string GetProductDetails()
    {
        return $"ProductID: {ProductID}, Name: {Name}, Price: {Price:C}";
    }

    public virtual decimal GetPrice()
    {
        return Price;
    }
}

// Physical Product
public class PhysicalProduct : Product
{
    public decimal ShippingCost { get; set; }

    public PhysicalProduct(string productId, string name, decimal price, decimal shippingCost)
        : base(productId, name, price)
    {
        ShippingCost = shippingCost;
    }

    public override decimal GetPrice()
    {
        return Price + ShippingCost;
    }

    public override string GetProductDetails()
    {
        return base.GetProductDetails() + $", ShippingCost: {ShippingCost:C}";
    }
}

// Digital Product
public class DigitalProduct : Product
{
    public string LicenseKey { get; set; }

    public DigitalProduct(string productId, string name, decimal price, string licenseKey)
        : base(productId, name, price)
    {
        LicenseKey = licenseKey;
    }

    public override string GetProductDetails()
    {
        return base.GetProductDetails() + $", LicenseKey: {LicenseKey}";
    }
}

// Subscription Product
public class SubscriptionProduct : Product
{
    public int SubscriptionDuration { get; set; } // in months

    public SubscriptionProduct(string productId, string name, decimal monthlyPrice, int duration)
        : base(productId, name, monthlyPrice)
    {
        SubscriptionDuration = duration;
    }

    public override decimal GetPrice()
    {
        return Price * SubscriptionDuration;
    }

    public override string GetProductDetails()
    {
        return base.GetProductDetails() + $", Duration: {SubscriptionDuration} months";
    }
}

// Order class
public class Order
{
    public string OrderID { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public Order(string orderId)
    {
        OrderID = orderId;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetPrice();
        }
        return total;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderID}");
        foreach (var product in Products)
        {
            Console.WriteLine(product.GetProductDetails() + $" | Total Price: {product.GetPrice():C}");
        }
        Console.WriteLine($"Total Order Price: {CalculateTotal():C}");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create products
        PhysicalProduct phone = new PhysicalProduct("P001", "Smartphone", 500m, 20m);
        DigitalProduct ebook = new DigitalProduct("D001", "E-Book", 15m, "ABC123XYZ");
        SubscriptionProduct netflix = new SubscriptionProduct("S001", "Netflix Subscription", 10m, 6);

        // Create order
        Order order = new Order("O1001");
        order.AddProduct(phone);
        order.AddProduct(ebook);
        order.AddProduct(netflix);

        // Display order details
        order.DisplayOrderDetails();

        Console.ReadLine();
    }
}
