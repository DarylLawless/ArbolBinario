using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    class Estudiante : IComparador
    {
        public int NumMat { get; set; }
        public string Nombre { get; set; }

        public bool IgualQue(object q)
        {
            Estudiante p2 = (Estudiante) q;
            return NumMat == p2.NumMat;
        }

        public bool MayorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return NumMat >= p2.NumMat;
        }

        public bool MayorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return NumMat > p2.NumMat;
        }

        public bool MenorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return NumMat <= p2.NumMat;
        }

        public bool MenorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return NumMat < p2.NumMat;
        }
    }
}
