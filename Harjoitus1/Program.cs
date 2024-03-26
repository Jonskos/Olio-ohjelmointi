using Harjoitus1;

internal class Program
{
    private static void Main(string[] args)
    {
        Ajoneuvo auto = new Ajoneuvo();

        auto.Nimi = "Toyota";
        auto.Nopeus = 160;
        auto.Renkaat = 4;

        auto.TulostaData();
    }
}