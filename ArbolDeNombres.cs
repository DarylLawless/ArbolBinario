using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class ArbolDeNombres
    {
        public ArbolDeNombres()
        {

        }

        public void ConstArbolNombres() 
        {
            CArbolBinario ArbolB;
            Nodo SubArbolIzquierdo; //A1
            Nodo SubArbolDerecho; //A2
            Nodo Raiz;//a

            Stack<Nodo> Pila = new Stack<Nodo>();

            SubArbolIzquierdo = CArbolBinario.NuevoArbol(null, "Maria", null);
            //otra forma
            SubArbolDerecho = new Nodo(null, "Rodrigo", null);

            Raiz = new Nodo(SubArbolIzquierdo, "Esperanza2", SubArbolDerecho);
            Pila.Push(Raiz);

            SubArbolIzquierdo = new Nodo(null, "Anyora", null);
            SubArbolDerecho = new Nodo(null, "Abel", null);
            Raiz = new Nodo(SubArbolIzquierdo, "MJesus", SubArbolDerecho);

            Pila.Push(Raiz);

            SubArbolDerecho = Pila.Pop();
            SubArbolIzquierdo = Pila.Pop();
            Raiz = new Nodo(SubArbolIzquierdo, "Esperanza1", SubArbolDerecho);

            ArbolB = new CArbolBinario(Raiz);
        }
    }
}
