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
            if(this.tamanho < this.elementos.Length){
                this.elementos[this.tamanho] = elemento;
                this.tamanho++;
            } else {
                throw new Exception("Vetor já está cheio, não é possível adicionar mais elementos.");
            }
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

        public void ListaElementos(){
            for(int i = 0; i < this.tamanho; i++){
                Console.WriteLine(this.elementos[i]);
            }
        }
    }
}