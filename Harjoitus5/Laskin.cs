using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    public static class Laskin
    {
        //Laskee parametrien summa
        public static float Summa(float a, float b)
        {
            return a + b;
        }
        //Laskee parametrien erotus
        public static float Erotus(float a, float b)
        {
            return a - b;
        }
        //Laskee parametrien kerto
        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }
        //Laskee parametrien jako
        public static float Jako(float a, float b)
        {
            return a / b;
        }

    }
}
