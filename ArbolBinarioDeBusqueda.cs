using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class ArbolBinarioDeBusqueda : CArbolBinario
    {
        public ArbolBinarioDeBusqueda(Nodo raiz) : base(raiz)
        {
            //this.Raiz = raiz;
        }

        public ArbolBinarioDeBusqueda() : base(null)
        { }

        public Nodo Buscar(object buscado)
        {
            IComparador dato;
            dato = (IComparador)buscado;
            if (Raiz == null)
            {
                return null;
            }
            else
            {
                return Localizar(Raiz, dato);
            }
        }

        protected Nodo Localizar(Nodo raizSub, IComparador buscado)
        {
            if (raizSub == null)
                return null;
            else if (buscado.IgualQue(raizSub.Dato))
                return Raiz;
            else if (buscado.MenorQue(raizSub.Dato))
                return Localizar(raizSub.NodoIzquierdo, buscado);
            else
                return Localizar(raizSub.NodoDerecho, buscado);



        }

        public Nodo BuscarIterativo(object buscado)
        {
            IComparador dato;
            bool encontrado = false;
            Nodo raizSub = Raiz;
            dato = (IComparador)buscado;
            while (!encontrado && raizSub != null)
            {
                if (dato.IgualQue(raizSub.Dato))
                    encontrado = true;
                else if (dato.MenorQue(raizSub.Dato))
                    raizSub = raizSub.NodoIzquierdo;
                else
                    raizSub = raizSub.NodoDerecho;

            }
            return raizSub;
        }

        public void Insertar(object valor)
        {
            IComparador dato;
            dato = (IComparador)valor;
            Raiz = InsertarEnArbol(Raiz, dato);
        }

        protected Nodo InsertarEnArbol(Nodo RaizSub, IComparador dato) 
        {
            if (RaizSub == null)
            {
                RaizSub = new Nodo(dato);
            }
            else if (dato.MenorQue(RaizSub.Dato))
            {
                Nodo iz;
                iz = InsertarEnArbol(RaizSub.NodoIzquierdo, dato);
                RaizSub.NodoIzquierdo = iz;
            }
            else if (dato.MayorQue(RaizSub.Dato))
            {
                Nodo dr;
                dr = InsertarEnArbol(RaizSub.NodoDerecho, dato);
                RaizSub.NodoDerecho = dr;
            }
            else 
            {
                throw new Exception("Nodo duplicado");
            }

            return RaizSub;
        }

        public void Eliminar(object valor) 
        {
            IComparador dato;
            dato = (IComparador)valor;
            Raiz = EliminarEnArbol(Raiz, dato);
        }

        protected Nodo EliminarEnArbol(Nodo RaizSub, IComparador dato) 
        {
            if (RaizSub == null)
            {
                throw new Exception("No encontrado nodo + clave");
            }
            else if (dato.MenorQue(Raiz.NodoIzquierdo))
            {
                Nodo iz;
                iz = EliminarEnArbol(RaizSub.NodoIzquierdo, dato);
                RaizSub.NodoIzquierdo = iz;
            }
            else if (dato.MayorQue(RaizSub.NodoDerecho))
            {
                Nodo dr;
                dr = EliminarEnArbol(RaizSub.NodoDerecho, dato);
                RaizSub.NodoDerecho = dr;
            }
            else 
            {
                Nodo q;
                q = RaizSub;
                if (q.NodoIzquierdo == null)
                {
                    RaizSub = q.NodoDerecho;
                }
                else if (q.NodoDerecho == null)
                {
                    RaizSub = q.NodoIzquierdo;
                }
                else 
                {
                    q = Reemplazar(q);
                }
                q = null;
            }
            return RaizSub;
        }

        private Nodo Reemplazar(Nodo act) 
        {
            Nodo a, p;
            p = act;
            a = act.NodoIzquierdo;
            while (a.NodoDerecho != null)
            {
                p = a;
                a = a.NodoDerecho;
            }
            act.Dato = a.Dato;
            if (p == act)
            {
                p.NodoIzquierdo = a.NodoIzquierdo;
            }
            else 
            {
                p.NodoDerecho = a.NodoDerecho;
            }
            return a;
        }

    }
}
