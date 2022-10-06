public abstract class Product
{
    public virtual float Price { get; set; }

    public Product(float price)
    {
        Price = price;
    }
}