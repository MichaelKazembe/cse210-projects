public class Customer
{
    // Private member attributes
    private string _name;
    private Address _address;

    // Constructor to initialize the customer
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Public getter method for accessing the name
    public string GetName()
    {
        return _name;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get the full address of the customer
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}
