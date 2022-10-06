public abstract class Product
{
    public string Type { get; private set; }
    //gjorde set till private så att grundpriset bara kan sättas i konstruktorn här
    public virtual float Price { get; private set; }

    public Product(float price, string type)
    {
        Type = type;
        Price = price;
    }
}