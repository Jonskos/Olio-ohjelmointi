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
        private string Etunimi;
        private string Sukunimi;
        private string Ryhtmätunnus;
        private int OpiskelijaID;
        public Opiskelija(string etunimi, string sukunimi, string ryhtmätunnus, int id)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Ryhtmätunnus = ryhtmätunnus;
            if (OpiskelijaIDLista.Add(id))
            {
                this.OpiskelijaID = id;
            }
            else
            {
                throw new Exception("ID on virheellinen");
            }
        }
    }
}
