using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("10-pack of socks", "10PKSCKS", 14.99, 1);
        Product p2 = new Product("paperback novel", "11PBN", 13.98, 3);
        Product p3 = new Product("teddy bear", "12TDDYBR", 9.99, 2);
        Product p4 = new Product("t-shirt", "592TSXS", 14.98, 5);
        Product p5 = new Product("heated blanket", "907HTDBLNKT-FULL", 45.48, 1);
        Product p6 = new Product("tote bag", "57TTBG-NAVY", 18.98, 4);

        Address a1 = new Address("998 Hillcrest Dr", "Fort Myers", "FL", "USA");
        Address a2 = new Address("8597 Race St", "Sidney", "BC", "Canada");

        Customer c1 = new Customer("Jane Doe", a1);
        Customer c2 = new Customer("John Jones", a2);

        Order o1 = new Order(c1);
        o1.AddToOrder(p1);
        o1.AddToOrder(p3);
        o1.AddToOrder(p6);
        
        Order o2 = new Order(c2);
        o2.AddToOrder(p2);
        o2.AddToOrder(p4);
        o2.AddToOrder(p5);

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine(o1.GetPackingLabel());
        Console.Write("Order Total: $");
        Console.WriteLine(o1.CalculateOrderTotal());
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine(o2.GetPackingLabel());
        Console.Write("Order Total: $");
        Console.WriteLine(o2.CalculateOrderTotal());
        Console.WriteLine();
    }
}