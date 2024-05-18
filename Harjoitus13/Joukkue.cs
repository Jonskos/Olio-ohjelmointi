using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    internal class Joukkue
    {
        private string Nimi;
        private string Kotikaupunki;
        private Dictionary<int, Pelaaja> Pelaajat = new Dictionary<int, Pelaaja>();
        public Pelaaja HaePelaaja(int numero)
        {
            return null;
        }
        public void LisääPelaaja(Pelaaja pelaaja)
        {

        }
        public void PoistaPelaaja(int numero)
        {

        }
        public List<Pelaaja> HaePelaajat()
        {
            return null;
        }
    }
}
