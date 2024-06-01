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
        //Käynnistää kiuaan
        public void Kaynnista()
        {
            paalla = true;
        }
        //Sammuttaa kiuaan
        public void Sammuta()
        {
            paalla = false;
        }
        //Palauttaa muuttujan "paalla" tilan
        public bool Paalla()
        {
            return paalla;
        }
        //Katsoo jos kiuas on päällä tai pois, ja palauttaa vastauksen
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
        //Vaihtaa kiukaan tilan päälle jos ei ole ja pois jos on
        public void Kaanna()
        {
            paalla = !paalla;
        }
        //Kiukaan constructori
        public Kiuas(bool paalla, int lampotila, int kosteus)
        {
            this.paalla = paalla;
            this.lampotila = lampotila;
            this.kosteus = kosteus;
        }
    }
}
