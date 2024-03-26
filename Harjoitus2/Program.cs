using Harjoitus2;

internal class Program
{
    private static void Main(string[] args)
    {
        Opiskelija Joonas = new Opiskelija("JOonas", "32AB", 179);
        Opiskelija Nikke = new Opiskelija("Nikke", "32AC", 1);
        Opiskelija Olavi = new Opiskelija("Olavi", "32AD", 301);

        Joonas.TulostaData();
        Console.WriteLine();

        Nikke.TulostaData();
        Console.WriteLine();

        Olavi.TulostaData();

    }
}