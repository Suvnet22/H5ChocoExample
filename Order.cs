public class Order
{
    List<Product> _products { get; set; } = new();
    public Donation? Donation { get; set; }

    public int OrderNo { get; private set; }
    public DateTime OrderDate { get; private set; }

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
        OrderNo = new Random().Next(100000, 999999);
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