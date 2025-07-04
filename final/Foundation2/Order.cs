using System.Text;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetShippingCost()
    {
        return customer.LivesInUSA() ? 5.0 : 35.0;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalPrice();
        }
        total += GetShippingCost();
        return total;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        foreach (var product in products)
        {
            sb.AppendLine($"{product.Name} (Product ID: {product.ProductId})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}