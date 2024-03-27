using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    internal class Eläin
    {
        public string genus;
        private int instanssit = 0;

        public Eläin()
        {
            instanssit++;
        }
    }
}
