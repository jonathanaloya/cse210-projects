namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product product1 = new Product("123", "Product 1", 10.99, 2);
            Product product2 = new Product("456", "Product 2", 5.99, 3);

            // Create customers
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer1 = new Customer("Jonathan Aloya", address1);

            Address address2 = new Address("456 Elm St", "London", "", "UK");
            Customer customer2 = new Customer("Omaje Joel", address2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);

            // Display packing label, shipping label, and total price for each order
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
        }
    }
}