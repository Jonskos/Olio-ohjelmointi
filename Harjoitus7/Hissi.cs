    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    internal class Hissi
    {
        //Kerros muuttuja
        private int kerros = 0;
        //Kerros ominaisuus, joka ei anna vaihtaa jos kerros on liian korkea tai liian matala
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
        //Siirtää hissin parametreihissä olevaan kerrokseen, jos mahdollista
        public void Siirra(int paateKerros)
        {
            SiirtoAnimaatio(paateKerros);
            Kerros = paateKerros;
            Thread.Sleep(100);
        }
        //Siirtoanimaatio kerroksien välillä, parametrinä päätekerros
        public void SiirtoAnimaatio(int paateKerros)
        {
            //tarkistaa jos kerros on liian korkea, ettei animaatio laukaise vaikka ei pysty mennä kerrokseen.
            if (paateKerros > 14)
            {
                Console.WriteLine("Error: Kerros on liian korkea.");
                return;

            }
            //tarkistaa jos kerros on liian matala
            else if (paateKerros < 0)
            {
                Console.WriteLine("Error: kerros on liian matala");
                return;
            }
            //jos kerros on korkeammalla kuin aloituskerros:
            //looppaa kerrosten läpi ylöspäin, joiden pitää mennä päästä päätekerrokseen
            if (Kerros < paateKerros)
            {
                for (int i = Kerros; i < paateKerros; i++)
                {
                    Console.WriteLine("Kerros " + i);
                    Thread.Sleep(500);
                }
                Console.WriteLine("Kerros " + paateKerros);
                Console.WriteLine("Perillä.");
            }
            //jos kerros on matalammalla kuin aloituskerros:
            //looppaa kerrosten läpi alaspäin, joiden pitää mennä päästä päätekerrokseen
            else if (Kerros > 0)
            {
                for (int i = Kerros; i > paateKerros; i--)
                {
                    Console.WriteLine("Kerros " + i);
                    Thread.Sleep(500);
                }
                Console.WriteLine("Kerros " + paateKerros);
                Console.WriteLine("Perillä.");
            }
            //jos on jo samassa kerroksessa
            else
            {
                Console.WriteLine("Olet jo siinä kerroksessa.");
            }
        }
    }
}
