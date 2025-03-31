public class Product
{
    // Private member attributes
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor to initialize the product
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Public getter methods for accessing private attributes
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    // Method to calculate the total cost of the product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}
