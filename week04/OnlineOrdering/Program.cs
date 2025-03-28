using System;
using System.Collections.Generic;


namespace OnlineOrdering;
class Program
{
        static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Address address2 = new Address("45 King Street", "London", "England", "UK");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 20, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);
        Product product4 = new Product("Monitor", "P004", 300, 1);
        Product product5 = new Product("Headphones", "P005", 100, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
        Console.WriteLine("-----------------------------");
    }
}