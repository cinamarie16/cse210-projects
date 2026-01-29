using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUsa()
    {
        if (_address.IsUsa())
        {
            return true;
        }
        return false;
    }
    public string GetShippingAddress()
    {
        string address = $"{_name}\n{_address.GetDisplayAddress()}";
        return address;
    }

}