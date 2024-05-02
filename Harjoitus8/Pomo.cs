using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    internal class Pomo : Henkilö
    {
        private string auto;
        private int boonus;
        private int pomoInstansseja = 0;
        private int PomoInstansseja
        {
            get { return pomoInstansseja; }
            set
            {
                if (value > 2)
                {
                    throw new ArgumentException("Value out of range");
                }
                else
                {
                    pomoInstansseja = value;
                }
            }
        }
        public Pomo(string nimi, string työpaikka, int palkkaKK, string auto, int boonus)
        {
            this.nimi = nimi;
            this.työpaikka = työpaikka;
            this.auto = auto;
            this.palkkaKK = palkkaKK;
            this.boonus = boonus;
            
            try
            {
                PomoInstansseja++;
            }
            catch
            {
                Console.WriteLine("Liian paljon pomojojja");
            }
            
        }
    }
}
