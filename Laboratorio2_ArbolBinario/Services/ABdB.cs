using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2_ArbolBinario.Services
{
    public class ABdBNodo<T>
    {
        private readonly T _value;
        private readonly List<ABdBNodo<T>> _hijo = new List<ABdBNodo<T>>();
        public ABdBNodo(T value)
        {
            _value = value;
        }
        public ABdBNodo<T> this[int i]
        {
            get { return _hijo[i]; }
        }


    }
}
