using System;
using System.Collections.Generic;

namespace OnlineOrdering;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

}
