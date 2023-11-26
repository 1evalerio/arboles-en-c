using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {//Inserta elementos en el arbol
            string NodoAniadir;			
			string LugarAniadir;
			string busqueda;
				
		  CArbol arbol = new CArbol();
		
		  CNodo raiz = arbol.Insertar("a",null);
		
		  arbol.Insertar("b", raiz);
		
		  arbol.Insertar("c", raiz);
		
		  CNodo n = arbol.Insertar("w",raiz);
		  arbol.Insertar("h",n);
		  
		  n= arbol.Insertar("e",raiz);
		  arbol.Insertar("i",n);
		  
		  n= arbol.Insertar("j",raiz);
		  arbol.Insertar("p",n);
		  arbol.Insertar("q",n);
		  
		  n = arbol.Insertar("d",raiz);
		  arbol.Insertar("h",n);
		  
		  arbol.Preorden(raiz);
		  Console.WriteLine("---------");
		  //arbol.PostOrder(raiz);
		
		 //Busca o localizar el nodo especifico en el arbol
		 Console.WriteLine("Cual desea buscar: ");
		 busqueda=Console.ReadLine();
		  CNodo encontrado = arbol.Buscar(busqueda,raiz);
		 if(encontrado != null){
		  	Console.WriteLine("Existe");
		  }
		  else
		  	Console.WriteLine("No se encontro");
		  
		  Console.Write("En donde deseas insertar: ");
		  LugarAniadir=Console.ReadLine();
		  Console.Write("Que desea insertar: ");
		  NodoAniadir=Console.ReadLine();
		  
		  encontrado = arbol.Buscar(LugarAniadir,raiz);
		  arbol.Insertar(NodoAniadir,encontrado);
		  arbol.Preorden(raiz);
		 // arbol.PostOrder(raiz);
		  



            //Arbol InOrder el cual es explicitamente binario
            ArbolBinario arbol2 = new ArbolBinario();
            NodoBinario raiz2 = arbol2.Inserta(6, null);


            arbol2.Inserta(2, raiz2);
            arbol2.Inserta(8, raiz2);
            arbol2.Inserta(1, raiz2);
            arbol2.Inserta(4, raiz2);
            arbol2.Inserta(3, raiz2);
            arbol2.Inserta(5, raiz2);
            arbol2.Inserta(7, raiz2);
            arbol2.Inserta(11, raiz2);
            arbol2.Inserta(9, raiz2);
            arbol2.Inserta(10, raiz2);
            arbol2.Inserta(0, raiz2);
            arbol2.Inserta(-1, raiz2);
            arbol2.Inserta(12, raiz2);

			Console.WriteLine("Muestra InOrder");
            arbol2.InOrder(raiz2);
            //Elimina un elemento
            Console.WriteLine();
            arbol2.EliminarNodoBinario(-1, raiz2);
			//Muestra en InOrder el arbol con el elemento eliminado
			Console.WriteLine("Arbol InOrder con el elemento eliminado");
            arbol2.InOrder(raiz2);

            Console.WriteLine("Presione una tecla para finalizar.....");
            Console.ReadKey(true);
        }
    }
}
