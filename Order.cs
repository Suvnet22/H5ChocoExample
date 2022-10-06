public class Order
{
    readonly List<Product> _products = new();
    public List<Product> Products
    {
        get
        {
            return _products;
        }
    }

    public Donation? Donation { get; set; }

    public int OrderNo { get; private set; } = new Random().Next(100000, 999999);
    public DateTime OrderDate { get; private set; } = DateTime.MinValue;

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

    public bool IsConfirmed { get; internal set; }

    public void Confirm()
    {
        IsConfirmed = true;
        OrderDate = DateTime.Now;
    }

    public void AddProduct(Product product)
    {
        //Tillåt inte att lägga till produkter till en order som är bekräftad
        if (IsConfirmed == false)
        {
            _products.Add(product);
        }
    }
}