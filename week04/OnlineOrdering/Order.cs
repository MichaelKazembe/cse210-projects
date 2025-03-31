using System.Collections.Generic;

public class Order
{
    // Private member attributes
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order
    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
