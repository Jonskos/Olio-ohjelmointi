using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12
{
    internal class Korttipakka
    {
        private int korttienMaara = 52;
        private bool jokeritPaalla = false;
        public List<string> maat = new List<string>()
        {
            "Pata",
            "Risti",
            "Hertta",
            "Ruutu"
        };
        private Dictionary<int, string> korttipakka = new Dictionary<int, string>();
        public Korttipakka()
        {
            if (korttienMaara % maat.Count != 0)
            {
                throw new Exception("Huono maiden tai korttien määrä");
            }
            int korttiaMaassa = korttienMaara / maat.Count;
            for (int i = 0; i < maat.Count; i++)
            {
                for (int j = 0; j < korttiaMaassa; j++)
                {
                    //Lisää kortit paikan mukaan ()
                    korttipakka.Add(j + korttiaMaassa * i, maat[i]);
                }
            }
        }
        public void TulostaPakka()
        {
            foreach(KeyValuePair<int, string> entry in korttipakka)
            {
                Console.WriteLine(entry.Key + entry.Value);
            }
        }
        public void Shuffle()
        {

        }
    }
}
