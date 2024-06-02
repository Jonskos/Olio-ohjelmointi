using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    internal class Radio
    {
        private bool paalla;
        private int aanenvoimakkuus;
        private float taajuus;

        public int Aanenvoimakkuus
        {
            get { return aanenvoimakkuus; }
            set
            {
                //Tarkistaa jos äänenvoimakkuus on liian matala tai liian korkea
                if (value > 10)
                {
                    throw new ArgumentException("Value too high");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("Value too low");
                }
                else
                {
                    aanenvoimakkuus = value;
                }
            }
        }
        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                //Tarkistaa jos taajuus on liian matala tai liian korkea
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
        public void Kytkin(bool paalla)
        {
            //Asettaa radion tilan
            this.paalla = paalla;
        }
        public void AanenvoimakkuusSaadin(int aanenvoimakkuus)
        {
            //Asettaa radion äänenvoimakkuuden
            this.Aanenvoimakkuus = aanenvoimakkuus;
        }
        public void TaajuusSaadin(float taajuus)
        {
            //Asettaa radion taajuuden
            this.Taajuus = taajuus;
        }
        
    }
}