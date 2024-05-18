using Harjoitus12;

internal class Program
{
    private static void Main(string[] args)
    {
        Korttipakka korttipakka = new Korttipakka();
        korttipakka.TulostaPakka();
        korttipakka.Shuffle();
        Console.WriteLine();
        korttipakka.TulostaPakka();
    }
}