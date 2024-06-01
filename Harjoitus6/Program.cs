using Harjoitus6;
internal class Program
{
    private static void Main(string[] args)
    {
        //Tehdään 4 uutta eläintä
        Eläin eläin = new Eläin();
        Eläin kissa = new Kissa();
        Koira koira = new Koira();
        Koira koira2 = new Koira();
        //Tulostaa eläinten instanssien määrä
        Console.WriteLine("Eläinten instanssit: " + Eläin.instanssit);
        eläin.Puhu();
        koira.Puhu();
        kissa.Puhu();
    }
}