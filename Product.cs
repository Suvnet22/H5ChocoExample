public abstract class Product
{
    public Category Category { get; set; }
    public string Type { get; private set; }
    //gjorde set till private så att grundpriset bara kan sättas i konstruktorn här
    public virtual float Price { get; private set; }

    public Product(float price, string type)
    {
        Type = type;
        Price = price;
    }
}

//Enumen ligger utanför Productklassen för att inte krocka med property-namnet Category
public enum Category
{
    Undefined,
    Food,
    Clothing
}