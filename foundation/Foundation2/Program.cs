using System;

class Program
{
    static void Main(string[] args)
    {
         // Creating some products
            Product product1 = new Product("Laptop", 101, 800, 2);
            Product product2 = new Product("Mouse", 102, 25, 1);
            Product product3 = new Product("Keyboard", 103, 50, 1);

            // Creating customers with different addresses
            Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
            Customer customer1 = new Customer("John Doe", address1);

            Address address2 = new Address("456 Maple Rd", "Vancouver", "BC", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);

            // Creating orders
            Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
            Order order2 = new Order(new List<Product> { product3 }, customer2);

            // Displaying packing labels, shipping labels, and total prices
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");

    }
}