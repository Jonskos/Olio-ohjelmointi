using Harjoitus12;

internal class Program
{
    private static void Main(string[] args)
    {
        Korttipakka korttipakka = new Korttipakka();
        //tulostaa korttipakan kortit eli sijainti pakassa, numero ja maa
        korttipakka.TulostaPakka();
        //randomisoi pakan
        korttipakka.Shuffle();
        Console.WriteLine();
        //tulostaa uudelleen
        korttipakka.TulostaPakka();
    }
}