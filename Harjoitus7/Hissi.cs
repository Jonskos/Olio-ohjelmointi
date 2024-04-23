    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    internal class Hissi
    {
        private int kerros = 0;
        private int Kerros
        {
            get { return kerros; }
            set
            {
                if (value > 14)
                {
                    Console.WriteLine("Error: Kerros on liian korkea.");
                }
                else if (value < 0)
                {
                    Console.WriteLine("Error: kerros on liian matala");
                }
                else
                {
                    kerros = value;
                }
            }
        }
        public Hissi() { }
        public void Siirra(int paateKerros)
        {
            //Kerros = paateKerros;
            SiirtoAnimaatio(paateKerros);
            Kerros = paateKerros;
            Console.WriteLine("Kerros "+ kerros);
            Console.WriteLine("Perillä.");
            Thread.Sleep(100);
        }
        public void SiirtoAnimaatio(int paateKerros)
        {
            if (paateKerros > 14)
            {
                Console.WriteLine("Error: Kerros on liian korkea.");
                return;

            }
            else if (paateKerros < 0)
            {
                Console.WriteLine("Error: kerros on liian matala");
                return;
            }
            if (Kerros < paateKerros)
            {
                for (int i = Kerros; i < paateKerros; i++)
                {
                    Console.WriteLine("Kerros " + i);
                    Thread.Sleep(500);
                }
            }
            else if (Kerros > 0)
            {
                for (int i = Kerros; i > paateKerros; i--)
                {
                    Console.WriteLine("Kerros " + i);
                    Thread.Sleep(500);
                }
            }
            else
            {
                Console.WriteLine("Olet jo siinä kerroksessa.");
            }
        }
    }
}
