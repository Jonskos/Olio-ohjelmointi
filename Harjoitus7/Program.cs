using Harjoitus7;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //instantioi uuden hissin
        Hissi hissi = new Hissi();
        Console.WriteLine("Hissin maksimikerros on 14.");
        //looppaa ikuisesti
        while (true)
        {
            Console.Write("Mihin kerrokseen haluat mennä? ");
            string input = Console.ReadLine();
            //testaa inputtia, ja siirtää jos on numero, muuten kysyy uudelleen.
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