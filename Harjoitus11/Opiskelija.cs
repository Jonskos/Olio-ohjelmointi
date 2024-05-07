using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11
{
    internal class Opiskelija
    {
        private static HashSet<int> OpiskelijaIDLista = new HashSet<int>();
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
        private string Etunimi;
        private string Sukunimi;
        private string Ryhtmätunnus;
        private int OpiskelijaID;
        public Opiskelija(string etunimi, string sukunimi, string ryhtmätunnus, int opiskelijaID)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Ryhtmätunnus = ryhtmätunnus;
            try { LisaaOpiskelija(opiskelijaID); }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
