using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Albumi
    {
        private List<Kappale> kappaleet = new List<Kappale>();
        private string nimi;
        private string artisti;
        private string genre;
        private float hinta;

        public void LisaaKappale(string nimi, float kesto)
        {
            kappaleet.Add(new Kappale(nimi, kesto, this.nimi));
        }
        public void TulostaTiedot()
        {
            Console.WriteLine("Albumin tiedot:");
            Console.WriteLine("Nimi: " + nimi);
            Console.WriteLine("Artisti: " + artisti);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Hinta: " + hinta + "€");
            Console.WriteLine("Kappaleet:");
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine("  " + kappale.nimi);
                Console.WriteLine("  Kesto: " + kappale.kesto);
            }
        }
        public Albumi(string nimi, string artisti, string genre, float hinta)
        {
            this.artisti = artisti;
            this.nimi = nimi;
            this.genre = genre;
            this.hinta = hinta;
        }

    }
}
