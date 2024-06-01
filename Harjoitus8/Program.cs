using Harjoitus8;

internal class Program
{
    private static void Main(string[] args)
    {
        //instantioi uuden pomon
        Pomo pomo1 = new Pomo("Jimi", "PomoPaikka", 120, "Ferrari", 20);
        //tulostaa pomon nimen
        Console.WriteLine(pomo1.nimi);
    }
}