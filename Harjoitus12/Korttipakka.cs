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
        //käytän dictionarya, intin joka on käytännössä dictionaryn indexi (en käyttänyt listaa älä kysy miksi) ja kortti, joka on tietenkin kortti
        private Dictionary<int, Kortti> korttipakka = new Dictionary<int, Kortti>();
        public Korttipakka()
        {
            //katsotaan jos korttien määrä on jaettavissa maitten määrällä, joten kortit voidaan jakaa tasaisesti
            if (korttienMaara % maat.Count != 0)
            {
                throw new Exception("Huono maiden tai korttien määrä");
            }
            //jaetaan korttien maara maiden maaralla
            int korttiaMaassa = korttienMaara / maat.Count;
            for (int i = 0; i < maat.Count; i++)
            {
                for (int j = 0; j < korttiaMaassa; j++)
                {
                    //Lisää kortit ensiksi yhdestä  korttienMaaraan asti ja lisataan korttiin maa ja kortin numero 1 - korttiaMaassa
                    korttipakka.Add((j + 1) + (korttiaMaassa * i), new Kortti(maat[i], j + 1));
                }
            }
        }
        public void TulostaPakka()
        {
            /*foreach(KeyValuePair<int, Kortti> entry in korttipakka)
            {
                Console.WriteLine("{0}. kortti pakassa on {1} - {2}", entry.Key, entry.Value.maa, entry.Value.numero);
            }*/
            for(int i = 1;i < korttipakka.Count;i++)
            {
                Console.WriteLine("{0}. kortti pakassa on {1} - {2}", i, korttipakka[i].maa, korttipakka[i].numero);
            }
        }
    }
}
