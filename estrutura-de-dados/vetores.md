# Vetores

<p>Um vetor (ou array) é a estrutura de dados mais simples que existe. 
Um vetor armazena uma sequêmcia de valores onde todos são do mesmo tipo.</p>
<p>Uma vez que cada variáveis têm o mesmo nome, o que as distingue é um índice, que referencia sua localização dentro da estrutura.</p>


```
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
```