public class Address
{
    // Private member attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize the address
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country == "USA";
    }

    // Method to get the full address as a string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}
