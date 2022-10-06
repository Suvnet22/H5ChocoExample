public class Chocolate : Product
{
    //Readonly betyder att _filling bara kan få en lista satt till sig en enda gång, dvs här där vi skriver new()
    readonly List<Filling> _filling = new();

    public override float Price
    {
        get
        {
            //Starta med grundpriset på chokladen
            float basePrice = base.Price;
            //Och lägg till priset för all filling
            foreach (Filling filling in _filling)
            {
                basePrice += filling.Price;
            }
            return basePrice;
        }
        set
        {
            //Här sätter vi bara priset i basklassen, som kan anses vara grundpriset för chokladen.
            base.Price = value;
        }
    }

    public Chocolate(float price) : base(price)
    {
    }

    public void AddFilling(Filling filling)
    {
        _filling.Add(filling);
    }
}