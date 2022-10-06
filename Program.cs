internal class Program
{
    private static void Main(string[] args)
    {
        //Skapa en ny order
        Order myOrder = new Order();

        //Skapa ett en choklad som kostar 100 och lägg till den till ordern
        Chocolate choco = new Chocolate();
        choco.Price = 100;
        myOrder.AddProduct(choco);

        //Skapa en keps som kostar 500 och lägg till den till ordern
        Cap cap = new Cap();
        cap.Price = 500;
        myOrder.AddProduct(cap);

        //Testa att skriva ut TotalPrice för att testa att den logiken funkar
        Console.WriteLine("Ny order skapad. Totalpris: " + myOrder.TotalPrice);
    }
}