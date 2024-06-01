using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Ajoneuvo
    {
        //get; set; joten voi asettaa muuttujan ulkopuolisesti.
        public string Nimi {  get; set; }
        public int Nopeus {  get; set; }
        public int Renkaat {  get; set; }

        //Tulostaa Ajoneivon data
        public void TulostaData() 
        {
            Console.WriteLine("Ajoneuvo: ");
            //Tulostaa ajoneuvon nimen
            Console.WriteLine("--Nmi:  " + Nimi);
            //Tulostaa ajoneuvon nopeuden
            Console.WriteLine("--Nopeus:  " + Nopeus);
            //Tulostaa ajoneuvon renkaat
            Console.WriteLine("--Renkaat:  " + Renkaat);
        } 
        public string ToString()
        {
            //yhdistää kaikki data yhteen merkkijonoon
            string merkkijono = $"Ajoneuvo: Nimi: {Nimi} Nopeus: {Nopeus} Renkaat: {Renkaat}";
            return merkkijono;
        }
    }
}
