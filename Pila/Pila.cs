using System;

namespace Pila
{
    class Pila
    {
        
        Nodo ultimo;

        public Pila(){            
            this.ultimo = null;
        }

        public void Push(int num){
            Console.WriteLine("Push");
            Nodo nodo = new Nodo(num);
            nodo.Anterior = null;
            
            if(this.ultimo == null){                
                this.ultimo = nodo;
                Console.WriteLine("Nodo pusheado.\n");                
                return;
            } 
            
            nodo.Anterior = this.ultimo;
            this.ultimo = nodo;
            
            Console.WriteLine("Nodo pusheado.\n");                            
        }

        public void Pop(){
            if(this.ultimo == null){
                Console.WriteLine("No hay elementos en la lista.\n");
                return;
            }

            Console.WriteLine("Pop: " + this.ultimo.Num);
            Nodo n = this.ultimo;
            int num = this.ultimo.Num;            
            this.ultimo = this.ultimo.Anterior;
            n = null;            
        }

        public void Mostrar(){
            Console.WriteLine("Mostrando Pila...");
            
            Nodo nodo = this.ultimo;

            while(nodo != null){
                Console.WriteLine(nodo.Num);
                nodo = nodo.Anterior;
            }

            Console.WriteLine();
        }
    }
}