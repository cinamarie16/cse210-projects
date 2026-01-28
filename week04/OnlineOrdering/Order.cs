using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int TotalOrderCost()
    {
        // information comes from the list<product>
        // must also add shipping cost $5 USA/ $35 other
        int totalCost = 0;
        return totalCost;
    }

    public string PackingLabel()
    {
        // info comes from list<product>
        string packingLabel = "";
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "";
        return shippingLabel;
    }
}