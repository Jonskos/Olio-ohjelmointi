using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12
{
    internal class Kortti
    {
        public string maa;
        public int numero;
        public Kortti(string maa, int numero)
        {
            this.maa = maa;
            this.numero = numero;
        }
    }
}
