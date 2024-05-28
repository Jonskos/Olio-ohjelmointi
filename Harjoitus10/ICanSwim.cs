using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal interface ICanSwim
    {
        int SwimSpeed { get; set; }
        private static void Swim() { }
    }
}
