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
        using (StreamWriter sw = File.AppendText("muistiinpanot.txt"))
        {
            string? input;
            while(true)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    sw.WriteLine(input);
                }
            }
            sw.WriteLine();
        }
    }
    public static void TulostaMuistiinpanot()
    {
        try
        {
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
        File.Delete("muistiinpanot.txt");
    }
}