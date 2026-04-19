using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Arboles_AVL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolAVL arbol = new ArbolAVL();

            arbol.raiz = arbol.Insertar(arbol.raiz, 10);
            arbol.raiz = arbol.Insertar(arbol.raiz, 400);
            arbol.raiz = arbol.Insertar(arbol.raiz, 30);
            arbol.raiz = arbol.Insertar(arbol.raiz, 40);
            arbol.raiz = arbol.Insertar(arbol.raiz, 100);
            arbol.raiz = arbol.Insertar(arbol.raiz, 25);

            Console.WriteLine("Recorrido en orden:");
            arbol.EnOrden(arbol.raiz);

            Console.ReadKey();
        }
    }
}
