public class Filling : Product
{
    public string Type { get; set; } = string.Empty;

    public Filling(float price) : base(price)
    {

    }
}