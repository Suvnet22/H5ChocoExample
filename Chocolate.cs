public class Chocolate : Product
{
    //Readonly betyder att _filling bara kan få en lista satt till sig en enda gång, dvs här där vi skriver new()
    readonly List<Filling> _filling = new();
    float _cacaoPricePerPercent = 0.5f;

    //Använder en private set så att CacaoAmount bara kan sättas via konstruktorn
    public int CacaoAmount { get; private set; }

    public override float Price
    {
        get
        {
            //Starta med grundpriset på chokladen, modifierad av cacaomängden
            float basePrice = base.Price + (_cacaoPricePerPercent * CacaoAmount);
            //Och lägg till priset för all filling
            foreach (Filling filling in _filling)
            {
                basePrice += filling.Price;
            }
            return basePrice;
        }
        //Tog bort Set ur de ärvda klasserna och gjorde den till private i Product
    }

    public Chocolate(float price, int cacaoAmount) : base(price)
    {
        //Se till så att cacaomängden inte kan vara mer än 100% eller mindre än 15%
        if (cacaoAmount > 100) cacaoAmount = 100;
        else if (cacaoAmount < 15) cacaoAmount = 15;

        CacaoAmount = cacaoAmount;
    }

    public void AddFilling(Filling filling)
    {
        _filling.Add(filling);
    }
}