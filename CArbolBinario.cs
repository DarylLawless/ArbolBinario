using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class CArbolBinario
    {
        public Nodo Raiz { get; set; }
        public CArbolBinario(Nodo raiz)
        {
            Raiz = raiz;
        }
        public CArbolBinario() : this(null)
        { }

        public bool EsVacio()
        {
            return Raiz == null;
        }

        public static Nodo NuevoArbol(Nodo ramaIzq, object dato, Nodo ramaDer)
        {
            return new Nodo(ramaIzq, dato, ramaDer);
        }
        //recorido de un arbol binario en preorden
        public static void Preorden(Nodo r)
        {
            if (r != null)
            {
                r.Visitar();
                Preorden(r.NodoIzquierdo);
                Preorden(r.NodoDerecho);
            }
        }

        //recorido de un arbol binario en inorden
        public static void InOrden(Nodo r)
        {
            if (r != null)
            {
                InOrden(r.NodoIzquierdo);
                r.Visitar();
                InOrden(r.NodoDerecho);
            }
        }

        //recorido de un arbol binario en postorden
        public static void PostOrden(Nodo r)
        {
            if (r != null)
            {
                PostOrden(r.NodoIzquierdo);
                PostOrden(r.NodoDerecho);
                r.Visitar();
            }
        }

        private int resultadoCantidadNodosHoja;

        public int CAntidadNodosHoja()
        {
            resultadoCantidadNodosHoja = 0;
            ContadorNodosHoja(Raiz);
            return resultadoCantidadNodosHoja;
        }

        public void ContadorNodosHoja(Nodo r) 
        {
            if (r != null)
            {
                ContadorNodosHoja(r.NodoIzquierdo);
                ContadorNodosHoja(r.NodoDerecho);
            }
            else 
            {
                resultadoCantidadNodosHoja ++;
            }
        }

        private int ContadorNivel;
        private int CantidadNodosEnNivel;
        public int NumeroDeNodosEnUnNivel(int nivel) 
        {
            ContadorNivel = 0;
            CantidadNodosEnNivel = 0;
            ContandoNiveles(Raiz,nivel);
            return CantidadNodosEnNivel;
        }
        public void ContandoNiveles(Nodo r, int nivel) 
        {
            if (r != null)
            {
                ContadorNivel += 1;
                if (ContadorNivel == nivel)
                {
                    CantidadNodosEnNivel += 1;
                }
                else
                {
                    ContandoNiveles(r.NodoIzquierdo, nivel);
                    ContandoNiveles(r.NodoDerecho, nivel);
                }
                r.Visitar();
                Preorden(r.NodoIzquierdo);
                Preorden(r.NodoDerecho);
            }
            else
            {
                ContadorNivel--;
            }
        }
    }
}
