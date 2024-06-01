using Harjoitus1;

internal class Program
{
    private static void Main(string[] args)
    {
        //instantioittaa uuden ajoneuvon "auto"
        Ajoneuvo auto = new Ajoneuvo();

        //asettaa auton nimen
        auto.Nimi = "Toyota";
        //asettaa auton nopeuden
        auto.Nopeus = 160;
        //asettaa auton renkaat
        auto.Renkaat = 4;

        //käyttää auto-classin funktiota joka tulostaa auton eri ominaisuudet
        auto.TulostaData();
        Console.WriteLine();
        //tulostaa auton eri ominaisuudet mutta yhdessä merkkijonossa
        Console.WriteLine(auto.ToString());
    }
}