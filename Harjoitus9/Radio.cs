using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    internal class Radio
    {
        private bool paalla;
        private int aanenvoimakkuus;
        private float taajuus;

        private int Aanenvoimakkuus
        {
            get
            { return aanenvoimakkuus; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: ");
                }
                else
                {
                    aanenvoimakkuus = value;
                }
            }
        }
    }
}