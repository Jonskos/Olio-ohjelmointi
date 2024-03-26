using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    internal class Kiuas
    {
        private bool paalla;
        public int lampotila;
        public int kosteus;
        public void Kaynnista()
        {
            paalla = true;
        }
        public void Sammuta()
        {
            paalla = false;
        }
        public bool Paalla()
        {
            return paalla;
        }
        public string Tila()
        {
            if (paalla == true)
            {
                return "Päällä";
            }
            else
            {
                return "Pois";
            }
        }
        public void Kaanna()
        {
            paalla = !paalla;
        }
        public Kiuas(bool paalla, int lampotila, int kosteus)
        {
            this.paalla = paalla;
            this.lampotila = lampotila;
            this.kosteus = kosteus;
        }
    }
}
