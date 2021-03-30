using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class ArbolDeExpresion
    {
        //Ejercicio 13.1 libro
        //((a*b)+(c/d)) expresion para meter al arbol y quue devuelva
        //ordenado en preorden, postorden e inorden

        public CArbolBinario ArbolB { get; private set; }
        private Nodo SubArbolIzquierdo; //A1
        private Nodo SubArbolDerecho; //A2
        private Nodo Raiz;//a
        private Stack<Nodo> Pila = new Stack<Nodo>();
        public ArbolDeExpresion()
        {
            ArbolB = null;
            SubArbolIzquierdo = null;
            SubArbolDerecho = null;
            Raiz = null;
            Pila = new Stack<Nodo>();
        }

        //expresion == ((a*b)+(c/d))
        public void CrearElArbolDeExpresion(string expresion) 
        {
            Nodo subarbolD = null;
            Nodo subarbolI = null;
            Nodo Raiz = null;

            List<string> ListaExpresiones = ProcesarExpresionEnNodos(expresion);

            Stack<char> PilaNodosInternos = new Stack<char>();

            foreach (string item in ListaExpresiones)
            {
                char[] expA = expresion.ToCharArray();
                if (item.Length == 3)
                {
                    
                    subarbolD = CrearSubArbol(null,expA[2].ToString(),null);
                    subarbolI = CrearSubArbol(null, expA[0].ToString(), null);
                    Raiz = CrearSubArbol(subarbolD, expA[1].ToString(), subarbolI);
                    Pila.Push(Raiz);
                }

                if (item.Length==1)
                {
                    PilaNodosInternos.Push(expA[0]);

                }
            }

            for (int i = 0; i < PilaNodosInternos.Count; i++)
            {
                subarbolD = Pila.Pop();
                subarbolI = Pila.Pop();
                Raiz = CrearSubArbol(subarbolD, PilaNodosInternos.Pop(), subarbolI); ;
            }

            

            //(a*b)+(c/d)
            subarbolD = Pila.Pop();
            subarbolI = Pila.Pop();
            Raiz = CrearSubArbol(subarbolD, "+", subarbolI);

            ArbolB = new CArbolBinario(Raiz);
        }

        private List<string> ProcesarExpresionEnNodos(string expresion) 
        {
            char[] expA = new char[expresion.Length];
            expA = expresion.ToCharArray();
            int contParentesisAbiertos = 0;
            int contParentesisCerrados = 0;
            string exp01 = "";

            foreach (char item in expA)
            {
                if (item == '(')
                {
                    contParentesisAbiertos++;
                }

                if (item != '(' || item != ')')
                {
                    exp01 += item;
                }
                else if (item != ')')
                {

                }
            }
        }

        public Nodo CrearSubArbol(Nodo nodoIzquierdo, char valor, Nodo nodoDerecho) 
        {
            Nodo subArbol = new Nodo(nodoIzquierdo, valor, nodoDerecho);
            return subArbol;
        }
    }
}
