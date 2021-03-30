using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class Nodo
    {
        public object Dato { get; set; }
        public Nodo NodoIzquierdo { get; set; }
        public Nodo NodoDerecho { get; set; }

        public Nodo(Nodo NodoIzq, Object valor, Nodo NodoDer)
        {
            this.Dato = valor;
            this.NodoIzquierdo = NodoIzq;
            this.NodoDerecho = NodoDer;
        }

        public Nodo(object valor): this(null, valor, null)
        {        }
        //mostrar el valor del dato del nodo
        public void Visitar() 
        {
            Console.Write(Dato + " ");
        }
    }
}
