using Harjoitus8;

internal class Program
{
    private static void Main(string[] args)
    {
        Pomo pomo1 = new Pomo("Jimi", "PomoPaikka", 120, "Ferrari", 20);
        Console.WriteLine(pomo1.nimi);
    }
}