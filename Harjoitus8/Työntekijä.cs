using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    internal class Työntekijä : Henkilö
    {
        private string tunnitVK;
        private string kaverit;
        public Työntekijä(string tunnitVK, string kaverit)
        {
            this.tunnitVK = tunnitVK;
            this.kaverit = kaverit;
        }
    }
}
