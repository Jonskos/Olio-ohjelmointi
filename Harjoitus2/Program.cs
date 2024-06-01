using Harjoitus2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Tekee kolme eri opiskelijaa
        Opiskelija Joonas = new Opiskelija("JOonas", "32AB", 179);
        Opiskelija Nikke = new Opiskelija("Nikke", "32AC", 1);
        Opiskelija Olavi = new Opiskelija("Olavi", "32AD", 301);

        //Tulostaa "Joonas" opiskelijan datan
        Joonas.TulostaData();
        Console.WriteLine();

        //Tulostaa "Nikke" opiskelijan datan
        Nikke.TulostaData();
        Console.WriteLine();

        //Tulostaa "Olavi" opiskelijan datan
        Olavi.TulostaData();

    }
}