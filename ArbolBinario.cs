using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Arboles
{
    internal class ArbolBinario
    {

        private NodoBinario raiz;

        private int i = 0;

        public ArbolBinario()
        {
            raiz = null;
        }

        internal NodoBinario Raiz { get { return raiz; } set { raiz = value; } }

        public NodoBinario Inserta(int pDato, NodoBinario pNodo)
        {
            NodoBinario aux = null;

            //Si no existe el nodo, se crea
            if (pNodo == null)
            {
                aux = new NodoBinario();
                aux.Dato = pDato;
                return aux;
            }

            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Inserta(pDato, pNodo.Izq);
            }

            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Inserta(pDato, pNodo.Der);
            }

            return pNodo;
        }

        public void InOrder(NodoBinario pNodo)
        {
            if (pNodo == null)
                return;
            //Proceso la izquierda primero si la tengo

            // si tengo izquierda, proceso a la izquierda |

            if (pNodo.Izq != null)
            {
                i++;
                InOrder(pNodo.Izq);
                i--;
            }

            Console.Write("{0}, ", pNodo.Dato);

            // si tengo Derecha, proceso a la izquierda |

            if (pNodo.Izq != null)
            {
                i++;
                InOrder(pNodo.Der);
                i--;
            }
        }
        //Se usa para borrar
        public NodoBinario BusquedaDelPadre(int pDato, NodoBinario pNodo)
        {
            NodoBinario aux = null;

            if (pNodo == null)
                return null;


            //Verifico si el nodo es el padre
            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo;

            if (pNodo.Der != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;

            //Si tengo izquierda, procedo a la izquierda
            if (pNodo.Izq != null && pDato < pNodo.Dato)
            {
                aux = BusquedaDelPadre(pDato, pNodo.Izq);
            }

            //Si tengo Derecha, procedo a la Derecha
            if (pNodo.Der != null && pDato > pNodo.Dato)
            {
                aux = BusquedaDelPadre(pDato, pNodo.Der);
            }
            return aux;
        }

        public NodoBinario EliminarNodoBinario(int pDato, NodoBinario pNodo)
        {
            if (pNodo == null)
            {
                return null;
            }

            if (pDato.CompareTo(pNodo.Dato) < 0)
            {
                pNodo.Izq = EliminarNodoBinario(pDato, pNodo.Izq);
            }
            else if (pDato.CompareTo(pNodo.Dato) > 0)
            {
                pNodo.Der = EliminarNodoBinario(pDato, pNodo.Der);
            }
            else
            {
                if (pNodo.Izq == null)
                {
                    return pNodo.Der;
                }
                else if (pNodo.Der == null)
                {
                    return pNodo.Izq;
                }

                pNodo.Dato = BuscarMinimo(pNodo.Der).Dato;
                pNodo.Der = EliminarNodoBinario(pNodo.Dato, pNodo.Der);
            }

            return pNodo;
        }

        public NodoBinario BuscarMinimo(NodoBinario pNodo)
        {
            if (pNodo.Izq == null)
            {
                return pNodo;
            }
            else
            {
                return BuscarMinimo(pNodo.Izq);
            }
        }
    }
}
