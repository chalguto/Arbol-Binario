using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _arbolBinario
{


    public class ArbolBinario
    {

        private Nodo raiz;
        int cant;

        public ArbolBinario()
        {
            this.raiz = null;
        }

        public void agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato, null, null);
            insertar(nuevo, raiz);
        }

        public void insertar(Nodo nuevo, Nodo pivote)
        {
            if (this.raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                if (nuevo.getDato() <= pivote.getDato())
                {
                    if (pivote.getIzq() == null)
                    {
                        pivote.setIzq(nuevo);
                    }
                    else
                    {
                        insertar(nuevo, pivote.getIzq());
                    }
                }
                else
                {
                    if (pivote.getDer() == null)
                    {
                        pivote.setDer(nuevo);
                    }
                    else
                    {
                        insertar(nuevo, pivote.getDer());
                    }
                }
            }

        }

        //metodos nuevos
        public bool existe(int info)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                cant++;
                if (info == reco.getDato()) return true;
                else if (info > reco.getDato()) reco = reco.getDer();
                else reco = reco.getIzq();
            }
            return false;
        }

        public int cantidad()
        {
            cant = 0;
            cantidad(raiz);
            return cant;
        }

        private void cantidad(Nodo reco)
        {
            if (reco != null)
            {
                cant++;
                cantidad(reco.getIzq());
                cantidad(reco.getDer());
            }
        }

        private void cantidadNodosHoja(Nodo reco)
        {
            if (reco != null)
            {
                if (reco.getIzq() == null && reco.getDer() == null)
                {
                    cant++;
                }
                cantidadNodosHoja(reco.getIzq());
                cantidadNodosHoja(reco.getDer());
            }
        }

        public int cantidadNodosHoja()
        {
            cant = 0;
            cantidadNodosHoja(raiz);
            return cant;
        }

        public int encontrarNodos(int inf)
        {
            int encont = 0;
            cant = 0;
            if (existe(inf)) encont = cant;
            return encont > 0 ? encont - 1 : encont;
        }

    }

}



