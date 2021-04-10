using System;

namespace Pila
{
    class Nodo
    {
        private int num;
        private Nodo anterior;

        public int Num { get => num; set => num = value; }
        public Nodo Anterior { get => anterior; set => anterior = value; }

        public Nodo(int num){
            this.num = num;
        }
    }
}