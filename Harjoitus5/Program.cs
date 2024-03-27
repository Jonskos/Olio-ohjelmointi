using Harjoitus5;

internal class Program
{
    private static void Main(string[] args)
    {
        float a;

        while (true)
        {
            Console.Write("Syötä numero: ");
            string syote = Console.ReadLine();
            if (float.TryParse(syote, out a))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ei ole numero.");
            }
        }
        float b;
        while (true)
        {
            Console.Write("Syötä numero: ");
            string syote = Console.ReadLine();
            if (float.TryParse(syote, out b))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ei ole numero.");
            }
        }
        Console.WriteLine($"Numeroiden {a} ja {b} summa on " + Laskin.Summa(a, b));
        Console.WriteLine($"Numeroiden {a} ja {b} erotus on " + Laskin.Erotus(a, b));
        Console.WriteLine($"Numeroiden {a} ja {b}  on " + Laskin.Kertolasku(a, b));
        Console.WriteLine($"Numeroiden {a} ja {b} on " + Laskin.Jako(a, b));
    }
}