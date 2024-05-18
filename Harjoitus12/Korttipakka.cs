using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Harjoitus12
{
    internal class Korttipakka
    {
        //aloitusluvut
        private int korttienMaara = 52;
        private bool jokeritPaalla = false;
        public List<string> maat = new List<string>()
        {
            "Pata",
            "Risti",
            "Hertta",
            "Ruutu"
        };
        //käytän listaa jossa on kortit
        private List<Kortti> korttipakka = new List<Kortti>();
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
                for (int j = 0; j < korttiaMaassa + 1; j++)
                {
                    //Lisään Kortin ja siihen maan ja numeron maassa.
                    korttipakka.Add(new Kortti(maat[i], j));
                }
            }
        }
        public void TulostaPakka()
        {
            for(int i = 1;i < korttipakka.Count;i++)
            {
                Console.WriteLine("{0}. kortti pakassa on {1} - {2}", i, korttipakka[i].maa, korttipakka[i].numero);
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            int n = korttipakka.Count;
            for (int i = 0; i < (n - 1); i++)
            {
                int r = i + random.Next(n - i);
                Kortti t = korttipakka[r];
                korttipakka[r] = korttipakka[i];
                korttipakka[i] = t;
            }
        }
    }
}
