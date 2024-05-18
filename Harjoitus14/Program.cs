internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mitä haluat tehdä?");
            Console.WriteLine("1. Lisää muistiinpano");
            Console.WriteLine("2. Tulosta muistiinpanot");
            Console.WriteLine("3. Poista muistiinpanot");
            string? input = Console.ReadLine();
            //katso käyttäjän vastaus, ja sitten kutsu metodi joka vastaa valintaa.
            switch (input)
            {
                case "1":
                    Console.Clear();
                    LisaaMuistiinpano();
                    break;
                case "2":
                    Console.Clear();
                    TulostaMuistiinpanot();
                    break;
                case "3":
                    Console.Clear();
                    PoistaMuistiinpanot();
                    break;
                case "":
                    return;
            }
        }
    }
    public static void LisaaMuistiinpano()
    {
        Console.WriteLine("Lisää muistiinpano: ");
        //Avataan streami
        using (StreamWriter sw = File.AppendText("muistiinpanot.txt"))
        {
            //asetetaan nullable string käyttäjän vastaukseksi
            string? input;
            while(true)
            {
                input = Console.ReadLine();
                //jos vastaus on tyhjä, lopetetaan muistiinpano
                if (input == "")
                {
                    break;
                }
                //muuten kirjoitetaan vastaus tiedostoon
                else
                {
                    sw.WriteLine(input);
                }
            }
            //väli muistiinpanojen väliin
            sw.WriteLine();
        }
    }
    public static void TulostaMuistiinpanot()
    {
        try
        {
            //kirjoita konsoliin muistiinpano linja linjaltaan
            foreach (string line in File.ReadLines("muistiinpanot.txt"))
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void PoistaMuistiinpanot()
    {
        //poistaa muistiinpano tiedosttot. en tyhjennä sitä, koska sillä ei ole paljon väliä, ja se on hyvin pienesti monimutkaisempi
        File.Delete("muistiinpanot.txt");
    }
}