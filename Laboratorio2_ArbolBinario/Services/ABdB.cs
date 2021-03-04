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
        public ABdBNodo<T> Padre { get; set; }
        public T Value { get { return _value; } }
        public ABdBNodo<T> AñadirHijo(T value)
        {
            var nodo = new ABdBNodo<T>(value) { Padre = this };
            _hijo.Add(nodo);
            return nodo;
        }
        public ABdBNodo<T>[] AñadirHijos(params T[] values)
        {
            return values.Select(AñadirHijo).ToArray();
        }
        public bool QuitarHijo(ABdBNodo<T> nodo)
        {
            return _hijo.Remove(nodo);
        }
        public void Recorrido(Action<T> action)
        {
            action(Value);
            foreach (var hijo in _hijo)
                hijo.Recorrido(action);
        }
        public IEnumerable<T> Aplanar()
        {
            return new[] { Value }.Concat(_hijo.SelectMany(x => x.Aplanar()));
        }
    }
}
