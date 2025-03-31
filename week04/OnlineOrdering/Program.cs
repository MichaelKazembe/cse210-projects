using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Rue Main", "Montreal", "QC", "Canada");

        // Create customers
        Customer customer1 = new Customer("Michael Kazembe", address1);
        Customer customer2 = new Customer("Joyce Banda", address2);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(new Product("Laptop", "Prod1", 2158.98m, 1));
        order1.AddProduct(new Product("Mouse", "Prod2", 25.99m, 2));

        order2.AddProduct(new Product("Monitor", "Prod3", 149.97m, 1));
        order2.AddProduct(new Product("Keyboard", "Prod4", 44.39m, 3));

        // Display order details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}\n");

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}\n");
    }
}
