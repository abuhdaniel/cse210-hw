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

    public bool LivesInNIGERIA()
    {
        return _address.IsNIGERIA();
    }

    public string GetShippingInfo()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}