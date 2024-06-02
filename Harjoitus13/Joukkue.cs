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
        public Pelaaja? HaePelaaja(int numero)
        {
            try
            {
                //Haetaan ja palautetaan pelaaja
                return Pelaajat[numero];
            }
            catch (Exception ex)
            {
                //tulostetaan error ja palautetaan null
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public void LisääPelaaja(Pelaaja pelaaja)
        {
            try
            {
                //lisätään pelaaja pelaajan numeron kanssa
                Pelaajat.Add(pelaaja.pelaajaNumero, pelaaja);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void PoistaPelaaja(int numero)
        {
            try
            {
                //poistetaan pelaaja pelaajan numeron kautta
                Pelaajat.Remove(numero);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public List<Pelaaja> HaePelaajat()
        {
            //tekee uuden listan
            var pelaajat = new List<Pelaaja>();
            //lisää siihen kaikki pelaajat Pelaajat dictionarysta
            foreach (Pelaaja pelaaja  in Pelaajat.Values)
            {
                pelaajat.Add(pelaaja);
            }
            //ja palauttaa sen
            return pelaajat;
        }
        public Joukkue(string nimi, string kotikaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
        }
    }
}
