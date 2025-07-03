class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LP100", 1200.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        Address addr2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Camera", "CM300", 550.00, 1));
        order2.AddProduct(new Product("Tripod", "TP400", 85.00, 1));

        var orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
            Console.WriteLine();
        }
    }
}