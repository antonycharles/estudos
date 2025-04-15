using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilhas
{
    public class Pilha<T>
    {
        private T[] elements;
        private int size;

        public Pilha(int capacidade)
        {
            this.elements = new T[capacidade];
            this.size = 0;
        }

        public void Push(T elemento)
        {
            increasesCapacity();
            elements[size] = elemento;
            size++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Pilha vazia");

            var elemento = elements[size - 1];
            size--;
            return elemento;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Pilha vazia");

            return elements[size - 1];
        }

        public int Size()
        {
            return size;
        }

        private void increasesCapacity(){
            if(this.size+1 <= this.elements.Length)
                return;

            var novoElemento = new T[this.elements.Length + 10];

            for(var i = 0; i < this.elements.Length;i++)
                novoElemento[i] = this.elements[i];

            this.elements = novoElemento;
        }

        public void Read(){
            for(int i = 0; i < this.size; i++){
                Console.WriteLine(this.elements[i]);
            }
        }
    }
}