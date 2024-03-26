using Harjoitus3;
internal class Program
{
    private static void Main(string[] args)
    {
        Kiuas kiuas = new Kiuas(false, 20, 5);
        Console.WriteLine(kiuas.Tila());
        kiuas.Kaynnista();
        Console.WriteLine(kiuas.Tila());
        kiuas.Sammuta();
        Console.WriteLine(kiuas.Tila());
        kiuas.Kaanna();
        Console.WriteLine(kiuas.Tila());

    }
}