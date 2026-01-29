using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string ID, double price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public double TotalProductCost()
    {
        double quantity = _quantity;
        double totalProductCost = _price * quantity;
        return totalProductCost;
    }

    public string GetPackingList()
    {
        string packingList = $"{_productID} {_productName} - {_quantity}";
        return packingList;
    }
}