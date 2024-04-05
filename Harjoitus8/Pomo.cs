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
        private int pomoInstansseja;
        public Pomo(string nimi, string työpaikka, int palkkaKK, string auto, int boonus)
        {
            this.auto = auto;
            this.boonus = boonus;
            if (pomoInstansseja <= 1)
            {
                throw new Exception("Ei saa olla enemmän kun yksi pomo");
            }
            else
            {
                pomoInstansseja++;
            }
        }
    }
}
