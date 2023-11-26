using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Arboles
{
    internal class CArbol
    {

        private CNodo raiz;
        private CNodo trabajo;
        private int i = 0;

        public CArbol()
        {
            raiz = new CNodo();
        }

        public CNodo Insertar(string pDato, CNodo pNodo)
        {
            //Si no existe ningun nodo, se coloca como la raiz	
            if (pNodo == null)
            {
                raiz = new CNodo();
                raiz.Dato = pDato;
                //No hay hijo
                raiz.Hijo = null;
                //No hay hermano
                raiz.Hermano = null;

                return raiz;
            }
            //Se verifica si contiene un hijo si no se coloca el dato como uno
            if (pNodo.Hijo == null)
            {
                CNodo temp = new CNodo();

                temp.Dato = pDato;
                //Se conecta el nuevo nodo como el hijo
                pNodo.Hijo = temp;

                return temp;
            }
            else
            {//Si ya tiene hijo se agrega como un hermano
                trabajo = pNodo.Hijo;

                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                //Se utiliza una variable auxiliar para almacenar el nodo temporalmente y asi guararlo
                CNodo temp = new CNodo();

                temp.Dato = pDato;
                //Añadimos el nodo temporal al nodo hermano
                trabajo.Hermano = temp;

                return temp;
            }


        }
        //Procesa el nodo luego los hijos
        public void Preorden(CNodo pNodo)
        {
            if (pNodo == null)
                return;
            //Primero se procesa el nodo
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);
            //Luego los hijos
            if (pNodo.Hijo != null)
            {
                i++;
                Preorden(pNodo.Hijo);
                i--;
            }
            //Luego los hermanos
            if (pNodo.Hermano != null)
                Preorden(pNodo.Hermano);
        }
        //Primero procesa los hijos y luego el nodo
        public void PostOrder(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            //Primero se procesa el hijo
            if (pNodo.Hijo != null)
            {
                i++;
                PostOrder(pNodo.Hijo);
                i--;
            }
            //Si tiene hermanos 
            if (pNodo.Hermano != null)
                Preorden(pNodo.Hermano);

            //Luego el nodo base
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);


        }

        public CNodo Buscar(string pDato, CNodo pNodo)
        {
            CNodo Encontrado = null;

            if (pNodo == null)
                return Encontrado;

            if (pNodo.Dato.CompareTo(pDato) == 0)
            {
                Encontrado = pNodo;
                return Encontrado;
            }

            //Si tiene un hijo
            if (pNodo.Hijo != null)
            {
                Encontrado = Buscar(pDato, pNodo.Hijo);

                if (Encontrado != null)
                    return Encontrado;
            }

            //Si tiene hermanos el nodo
            if (pNodo.Hermano != null)
            {
                Encontrado = Buscar(pDato, pNodo.Hermano);
                if (Encontrado != null)
                    return Encontrado;
            }
            return Encontrado;

        }
    }
}
