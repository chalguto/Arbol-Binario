using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _arbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario abo = new ArbolBinario();
            int dt;

            Console.WriteLine(" Insertando los siguientes 7 valores ");
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"Inserte valor {i}: ");
                abo.agregar(Convert.ToInt32(Console.ReadLine().ToString()));
            }

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("1.- Cantidad de nodos del arbol");
                Console.WriteLine("2.- Cantidad de nodos hoja");
                Console.WriteLine("3.- Buscar la distancia entre la raiz y un nodo");
                Console.WriteLine("0.- Salir");
                dt = Convert.ToInt32(Console.ReadLine().ToString());

                switch (dt)
                {
                    case 1:
                        Console.WriteLine("Cantidad de nodos del árbol:" + abo.cantidad());
                        break;
                    case 2:
                        Console.WriteLine("Cantidad de nodos hoja:" + abo.cantidadNodosHoja());
                        break;
                    case 3:
                        Console.Write("Ingrese nodo: ");
                        int nodo = Convert.ToInt32(Console.ReadLine().ToString());

                        Console.WriteLine("Distancia entre la raíz y el nodo: " + abo.encontrarNodos(nodo));
                        break;
                }
            } while (dt != 0);


            Console.Read();
        }
    }

}
