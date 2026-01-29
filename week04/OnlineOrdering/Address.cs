using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }
    
    public bool IsUsa()
    {
        if (_country == "USA" || _country == "Usa")
        {
            return true;
        }
        return false;
    }

    public string GetDisplayAddress()
    {
        string address = $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
        return address;
    }
}