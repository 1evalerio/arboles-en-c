using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Arboles
{
    internal class NodoBinario
    {
        private int dato;
        private NodoBinario izq;
        private NodoBinario der;

        public NodoBinario Izq { get { return izq; } set { izq = value; } }
        public NodoBinario Der { get { return der; } set { der = value; } }
        public int Dato { get { return dato; } set { dato = value; } }

        public NodoBinario()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }
}
