using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    internal class Pelaaja
    {
        public string etunimi { get; }
        public string sukunimi { get; }
        public int pelaajaNumero { get; }
        public Pelaaja(string _etunimi, string _sukunimi, int _pelaajaNumero)
        {
            etunimi = _etunimi;
            sukunimi = _sukunimi;
            pelaajaNumero = _pelaajaNumero;
        }
    }
}
