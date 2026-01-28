using System;

public class Product
{
    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string name, int ID, int price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        int totalCost = _price * _quantity;
        return totalCost;
    }
}