using Harjoitus13;

internal class Program
{
    private static void Main(string[] args)
    {
        //Tehdään joukkue
        Joukkue joukkue1 = new Joukkue("New York Mets", "New York");
        //lisätään kolme pelaajaa
        Pelaaja Pelaaja1 = new Pelaaja("Mikke", "Koivuniemi", 12);
        joukkue1.LisääPelaaja(Pelaaja1);
        Pelaaja Pelaaja2 = new Pelaaja("Nikke", "Koivuniemi", 11);
        joukkue1.LisääPelaaja(Pelaaja2);
        Pelaaja Pelaaja3 = new Pelaaja("Likke", "Tamminiemi", 20);
        joukkue1.LisääPelaaja(Pelaaja3);
        //Tulostetaan pelaajan etunimi ja sukunimi
        Console.WriteLine(joukkue1.HaePelaaja(12).etunimi);
        Console.WriteLine(joukkue1.HaePelaaja(12).sukunimi);
        //haetaan ja tulostetaan pelaajat joukkueessa
        var pelaajat = joukkue1.HaePelaajat();
        foreach (var p in pelaajat)
        {
            Console.WriteLine("{0} {1} {2}", p.etunimi, p.sukunimi, p.pelaajaNumero);
        }
        //poistetaan ja haetaan pelaaja joukkueesta
        joukkue1.PoistaPelaaja(20);
        Console.WriteLine();
        pelaajat = joukkue1.HaePelaajat();
        foreach (var p in pelaajat)
        {
            Console.WriteLine("{0} {1} {2}", p.etunimi, p.sukunimi, p.pelaajaNumero);
        }
    }
}