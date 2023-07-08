using System;
using System.Collections.Generic;

namespace Encapsulation
{
    // This program demonstrates the use of classes and their properties to encapsulate data and functionality.
    public class Program
    {
        public static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Townsville ", "CA", "USA");
            Customer customer1 = new Customer("John Munina", address1);
            Order order1 = new Order(customer1);
            Product product1 = new Product("Product 1", 1, 10.5m, 2);
            Product product2 = new Product("Product 2", 2, 15.75m, 1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Address address2 = new Address("546 Elm St", "Cityville", "NY", "Canada");
            Customer customer2 = new Customer("Jackeline Ngalula", address2);
            Order order2 = new Order(customer2);
            Product product3 = new Product("Product 3", 3, 8.99m, 3);
            order2.AddProduct(product3);

            Console.WriteLine("Order 1");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

            Console.WriteLine();

            Console.WriteLine("Order 2");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());

            Console.ReadLine();
        }
    }
}