using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Arboles
{
    internal class CNodo
    {

        private string dato;
        private int _dato;
        private CNodo hijo;
        private CNodo hermano;


        public string Dato { get { return dato; } set { dato = value; } }
        public CNodo Hijo { get { return hijo; } set { hijo = value; } }
        public CNodo Hermano { get { return hermano; } set { hermano = value; } }
        public int _Dato { get { return _dato; } set { _dato = value; } }


        public CNodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
