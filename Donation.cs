public class Donation
{
    public float Amount { get; }
    public string Company { get; }

    //Administrationskostnad satt till 4%. Readonly så den kan inte ändras i kod på andra ställen, enbart här
    private readonly float _administrationFee = 0.04f;

    public Donation(float amount, string company)
    {
        Amount = amount - (amount * _administrationFee);
        Company = company;
    }
}