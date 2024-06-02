using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    internal class Kanava
    {
        //Staattinen lista, johon laitetaan kaikki kanavat
        public static Dictionary<float,string> kanavat = new Dictionary<float, string>();
        private string nimi;
        private float taajuus;
        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                //katsoo jos taajuus on liian matala tai liian korkea
                if (value < 88)
                {
                    throw new ArgumentException("Value too low");
                }
                else if (value > 107.9)
                {
                    throw new ArgumentException("Value too highi");
                }
                else
                {
                    taajuus = value;
                }
            }
        }
        public Kanava(string nimi, float taajuus)
        {
            this.nimi = nimi;
            try
            {
                this.Taajuus = taajuus;
            }
            catch { }
            //lisää kanavan kanavat-listaan
            kanavat.Add(taajuus,nimi);
        }
    }
}
