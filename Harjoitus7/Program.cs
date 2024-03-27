using System;
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Mihin kerrokseen haluat mennä? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                
            }
            else
            {
                Console.WriteLine("Syötä numero.");
                Thread.Sleep(100);
            }
        }
    }
}