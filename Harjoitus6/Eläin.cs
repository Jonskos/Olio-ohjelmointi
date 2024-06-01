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
        public static int instanssit = 0;
        //Eläin classin konstruktori
        public Eläin()
        {
            //lisää instanssien numeroihin, kun instantioidaan uusi eläin
            instanssit++;
        }
        //Virtuaalinen metodi, jotka aliluokat ylikirjoittaa
        public virtual void Puhu()
        {
            Console.WriteLine("Eläin puhuu.");
        }
    }
}
