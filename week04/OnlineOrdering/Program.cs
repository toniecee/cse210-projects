using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("450 Maple Ave", "Boise", "ID", "USA");
        Customer customer1 = new Customer("Hannah Miller", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Wireless Mouse", "WM-104", 24.50, 2),
            new Product("Mechanical Keyboard", "MK-208", 79.00, 1),
            new Product("USB-C Hub", "UH-312", 19.99, 2)
        };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("18 King Street West", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("David Patel", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Desk Lamp", "DL-501", 34.00, 1),
            new Product("Notebook Pack", "NP-110", 8.75, 3)
        };
        Order order2 = new Order(customer2, products2);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}