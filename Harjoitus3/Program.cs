using Harjoitus3;
internal class Program
{
    private static void Main(string[] args)
    {
        Kiuas kiuas = new Kiuas(false, 20, 5);
        Console.WriteLine(kiuas.Tila());
        kiuas.Kaynnista();
        kiuas.lampotila = 40;
        kiuas.kosteus = 50;
        Console.WriteLine(kiuas.Tila());
        Console.WriteLine("Lämpötila: " + kiuas.lampotila);
        Console.WriteLine("Kosteus: " + kiuas.kosteus + "%");
        kiuas.Sammuta();
        kiuas.lampotila = 20;
        kiuas.kosteus = 20;
        Console.WriteLine(kiuas.Tila());
        Console.WriteLine("Lämpötila: " + kiuas.lampotila);
        Console.WriteLine("Kosteus: " + kiuas.kosteus + "%");

        kiuas.Kaanna();
        kiuas.lampotila = 40;
        kiuas.kosteus = 60;
        Console.WriteLine(kiuas.Tila());
        Console.WriteLine("Lämpötila: " + kiuas.lampotila);
        Console.WriteLine("Kosteus: " + kiuas.kosteus + "%");


    }
}