using System;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddToOrder(Product product)
    {
        _products.Add(product);
    }

    public double CalculateOrderTotal()
    {
        double subTotal = 0;
        foreach(Product p in _products)
        {
            subTotal += p.TotalProductCost();
        }
        
        if (_customer.IsUsa())
        {
            double totalCost = subTotal + 5;
            return totalCost;
        }
        else
        {
            double totalCost = subTotal + 35;
            return totalCost;
        }
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (Product product in _products)
        {
            packingLabel.AppendLine(product.GetPackingList());
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _customer.GetShippingAddress();
        return shippingLabel;
    }
}