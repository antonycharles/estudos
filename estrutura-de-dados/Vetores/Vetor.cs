using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores
{
    public class Vetor<T>
    {
        private T[] elementos;
        private int tamanho;

        public Vetor(int capacidade)
        {
            this.elementos = new T[capacidade];
            this.tamanho = 0;
        }

        public void Adiciona(T elemento){
            aumentaCapacidade();
            if(this.tamanho < this.elementos.Length){
                this.elementos[this.tamanho] = elemento;
                this.tamanho++;
            } else {
                throw new Exception("Vetor já está cheio, não é possível adicionar mais elementos.");
            }
        }

        public void Adiciona(int posicao, T elemento){
            aumentaCapacidade();
            if(posicao > this.tamanho || posicao < 0)
                throw new Exception("Posíção inválida");

            for(int i = this.tamanho; i > posicao ;i--){
                this.elementos[i] = this.elementos[i-1];
            }

            this.elementos[posicao] = elemento;
            this.tamanho++;
        }

        public void Remove(int posicao){
            if(posicao >= this.tamanho || posicao < 0)
                throw new Exception("Posição inválida");

            for(int i = posicao; i < this.tamanho-1;i++)
                this.elementos[i] = this.elementos[i+1];

            this.tamanho--;
        }

        private void aumentaCapacidade(){
            if(this.tamanho+1 <= this.elementos.Length)
                return;

            var novoElemento = new T[this.elementos.Length + 1];

            for(var i = 0; i < this.elementos.Length;i++)
                novoElemento[i] = this.elementos[i];

            this.elementos = novoElemento;
        }

        public int BuscaPosicao(T elemento){
            for(int i = 0; i < this.tamanho; i++){
                if(this.elementos[i].Equals(elemento)){
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T elemento){
            for(int i = 0; i < this.tamanho; i++){
                if(this.elementos[i].Equals(elemento))
                    return true;
            }

            return false;
        }

        public T Busca(int posicao){
            if(posicao < 0 || posicao >= this.tamanho){
                throw new Exception("Posição inválida.");
            }

            return this.elementos[posicao];
        }

        public int GetTamanho(){
            return this.tamanho;
        }

        public void ListaElementos(){
            for(int i = 0; i < this.tamanho; i++){
                Console.WriteLine(this.elementos[i]);
            }
        }
    }
}