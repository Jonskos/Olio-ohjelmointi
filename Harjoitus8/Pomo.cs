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
        public Pomo(string auto, int boonus)
        {
            pomoInstansseja++;
            this.auto = auto;
            this.boonus = boonus;
            if (pomoInstansseja = 1)
            {
                
            }
        }
    }
}
