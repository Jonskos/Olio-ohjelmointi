using Harjoitus7;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Hissi hissi = new Hissi();
        Console.WriteLine("Hissin maksimikerros on 14.");
        while (true)
        {
            Console.Write("Mihin kerrokseen haluat mennä? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                hissi.Siirra(value);
            }
            else
            {
                Console.WriteLine("Syötä numero.");
                Thread.Sleep(100);
            }
        }
    }
}