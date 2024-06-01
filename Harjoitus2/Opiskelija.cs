using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Opiskelija
    {
        //get; set; joten voi asettaa muuttujan ulkopuolisesti.
        private string Nimi { get; set; }
        private string OpiskelijaID { get; set; }
        private int Opintopisteet { get; set; }

        //tulostaa opiskelijan eri ominaisuudet
        public void TulostaData()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("OpiskelijaID " + OpiskelijaID);
            Console.WriteLine("Opintopisteet: " + Opintopisteet);
        }
        //Muuntaa oppilaan opintopisteet annetuiksi parametreiksi
        public void MuokkaaOpintopisteitä(int pisteMaara)
        {
            Opintopisteet = pisteMaara;
        }
        //Opiskelijan konstruktori
        public Opiskelija(string _nimi, string _opiskelijaID, int _opintopisteet)
        {
            Nimi = _nimi;
            OpiskelijaID = _opiskelijaID;
            Opintopisteet = _opintopisteet;
        }
    }
}