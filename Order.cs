public class Order
{
    List<Product> _products { get; set; } = new();
    public Donation? Donation { get; set; }

    public float TotalPrice
    {
        get
        {
            float totalPrice = 0;
            foreach (Product product in _products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}