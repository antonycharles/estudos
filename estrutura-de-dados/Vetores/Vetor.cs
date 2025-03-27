using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores
{
    public class Vetor
    {
        private string[] elementos;
        private int tamanho;

        public Vetor(int capacidade)
        {
            this.elementos = new string[capacidade];
            this.tamanho = 0;
        }

        public void Adiciona(string elemento){
            aumentaCapacidade();
            if(this.tamanho < this.elementos.Length){
                this.elementos[this.tamanho] = elemento;
                this.tamanho++;
            } else {
                throw new Exception("Vetor já está cheio, não é possível adicionar mais elementos.");
            }
        }

        public void Adiciona(int posicao, string elemento){
            aumentaCapacidade();
            if(posicao > this.tamanho || posicao < 0)
                throw new Exception("Posíção inválida");

            for(int i = this.tamanho; i > posicao ;i--){
                this.elementos[i] = this.elementos[i-1];
            }

            this.elementos[posicao] = elemento;
            this.tamanho++;
        }

        private void aumentaCapacidade(){
            if(this.tamanho+1 <= this.elementos.Length)
                return;

            var novoElemento = new string[this.elementos.Length + 1];

            for(var i = 0; i < this.elementos.Length;i++)
                novoElemento[i] = this.elementos[i];

            this.elementos = novoElemento;
        }

        public int BuscaPosicao(string elemento){
            for(int i = 0; i < this.tamanho; i++){
                if(this.elementos[i] == elemento){
                    return i;
                }
            }

            return -1;
        }

        public string Busca(int posicao){
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