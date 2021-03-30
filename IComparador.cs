using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    interface IComparador
    {
        public bool IgualQue(object q);
        public bool MayorIgualQue(object q);
        public bool MayorQue(object q);
        public bool MenorIgualQue(object q);
        public bool MenorQue(object q);
    }
}
