using Harjoitus5;

internal class Program
{
    private static void Main(string[] args)
    {
        //Käyttäjän input muuttuja
        float input1;

        while (true)
        {
            Console.Write("Syötä numero: ");
            string syote = Console.ReadLine();
            if (float.TryParse(syote, out input1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ei ole numero.");
            }
        }
        //Käyttäjän toinen input muuttuja
        float input2;
        while (true)
        {
            Console.Write("Syötä numero: ");
            string syote = Console.ReadLine();
            if (float.TryParse(syote, out input2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ei ole numero.");
            }
        }

        Console.WriteLine($"Numeroiden {input1} ja {input2} summa on " + Laskin.Summa(input1, input2));
        Console.WriteLine($"Numeroiden {input1} ja {input2} erotus on " + Laskin.Erotus(input1, input2));
        Console.WriteLine($"Numeroiden {input1} ja {input2}  on " + Laskin.Kertolasku(input1, input2));
        Console.WriteLine($"Numeroiden {input1} ja {input2} on " + Laskin.Jako(input1, input2));
    }
}