using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Kappale
    {
        public string nimi;
        public float kesto;
        private string albumi;
        public string ToString()
        {
            return "Nimi: " + nimi + " Kesto: " + kesto + " Albumi: " + albumi;
        }
        public Kappale(string nimi, float kesto, string albumi)
        {
            this.nimi = nimi;
            this.kesto = kesto;
            this.albumi = albumi;
        }

    }
}
