using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus20
{
    [Serializable()]
    internal class Opiskelija
    {
        private static HashSet<int> OpiskelijaIDLista = [];
        private static HashSet<string> SähköpostiLista = [];
        private void LisaaOpiskelija(int opiskelijaID)
        {
            if (OpiskelijaIDLista.Add(opiskelijaID))
            {
                this.OpiskelijaID = opiskelijaID;
            }
            else
            {
                throw new ArgumentException("ID on virheellinen");
            }
        }
        private void LisääSähköposti(string sähköposti)
        {
            if (SähköpostiLista.Add(sähköposti))
            {
                this.sähköposti = sähköposti;
            }
            else
            {
                throw new ArgumentException("Sähköposti on virheellinen");
            }
        }
        public string Etunimi;
        public string Sukunimi;
        public int OpiskelijaID;
        public string sähköposti;
        public int puhelinnumero;
        public Opiskelija(string etunimi, string sukunimi, int opiskelijaID, string sähköposti, int puhelinnumero)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.puhelinnumero = puhelinnumero;
            try { LisaaOpiskelija(opiskelijaID); }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try { LisääSähköposti(sähköposti); }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        ~Opiskelija()
        {
            try { OpiskelijaIDLista.Remove(this.OpiskelijaID); }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try { SähköpostiLista.Remove(this.sähköposti); }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
}
}
