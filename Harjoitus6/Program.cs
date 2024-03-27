using Harjoitus6;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Eläin eläin = new Eläin();
        Eläin kissa = new Kissa();
        Koira koira = new Koira();
        Koira koira2 = new Koira();
        Console.WriteLine("Eläinten instanssit: " + Eläin.instanssit);
        eläin.Puhu();
        koira.Puhu();
        kissa.Puhu();
    }
}