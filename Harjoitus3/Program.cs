using Harjoitus3;
internal class Program
{
    private static void Main(string[] args)
    {
        //instantioi uuden kiukaan
        Kiuas kiuas = new Kiuas(false, 20, 5);
        //tulostaa kiukaan tilan
        Console.WriteLine(kiuas.Tila());
        //käynnistää kiukaan
        kiuas.Kaynnista();
        //Asettaa kiukaan lämpötila ja kosteus.
        kiuas.lampotila = 40;
        kiuas.kosteus = 50;
        //tulostaa kiukaan tilan, lämpötilan ja kosteuden
        Console.WriteLine(kiuas.Tila());
        Console.WriteLine("Lämpötila: " + kiuas.lampotila);
        Console.WriteLine("Kosteus: " + kiuas.kosteus + "%");
        //Sammuttaa kiukaan, ja asettaa lämpötilan ja kosteuden alemmaksi
        kiuas.Sammuta();
        kiuas.lampotila = 20;
        kiuas.kosteus = 20;
        //tulostaa kiukaan tilan, lämpötilan ja kosteuden
        Console.WriteLine(kiuas.Tila());
        Console.WriteLine("Lämpötila: " + kiuas.lampotila);
        Console.WriteLine("Kosteus: " + kiuas.kosteus + "%");
        //Kääntää kiukaan kahvan (eli muuttaa kiukaan tilan toiseksi kun se oli ennen)
        kiuas.Kaanna();
        kiuas.lampotila = 40;
        kiuas.kosteus = 60;
        //tulostaa kiukaan tilan, lämpötilan ja kosteuden
        Console.WriteLine(kiuas.Tila());
        Console.WriteLine("Lämpötila: " + kiuas.lampotila);
        Console.WriteLine("Kosteus: " + kiuas.kosteus + "%");


    }
}