using System;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila p = new Pila();
            p.Push(5);
            p.Push(6);
            p.Push(7);            
            p.Mostrar();

            p.Pop();
            p.Mostrar();

            p.Pop();
            p.Mostrar();
            
            p.Pop();
            p.Mostrar();

            p.Pop();
            
            p.Push(7);            
            p.Mostrar();

        }
    }
}
