# Vetores
![Image](https://github.com/user-attachments/assets/9a927749-7b86-405d-b34e-bf55f1a1d713)
<p>Um vetor (ou array) é a estrutura de dados mais simples que existe. 
Um vetor armazena uma sequêmcia de valores onde todos são do mesmo tipo.</p>
<p>Uma vez que cada variáveis têm o mesmo nome, o que as distingue é um índice, que referencia sua localização dentro da estrutura.</p>
<p>Normalmente, um vetor é a encapsulação de um array com uma série de métodos que permitem controlar esse array de uma forma mais dinâmica.</p>


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
}
```

## Métodos

### Adiciona elemento
```
public void Adiciona(T elemento){
    aumentaCapacidade();
    if(this.tamanho < this.elementos.Length){
        this.elementos[this.tamanho] = elemento;
        this.tamanho++;
    } else {
        throw new Exception("Vetor já está cheio, não é possível adicionar mais elementos.");
    }
}
```

### Adiciona elemento na posição
```
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
```

### Remove elemento pela posição
```
public void Remove(int posicao){
    if(posicao >= this.tamanho || posicao < 0)
        throw new Exception("Posição inválida");

    for(int i = posicao; i < this.tamanho-1;i++)
        this.elementos[i] = this.elementos[i+1];

    this.tamanho--;
}
```

### Aumenta capacidade de um vetor
```
private void aumentaCapacidade(){
    if(this.tamanho+1 <= this.elementos.Length)
        return;

    var novoElemento = new T[this.elementos.Length + 1];

    for(var i = 0; i < this.elementos.Length;i++)
        novoElemento[i] = this.elementos[i];

    this.elementos = novoElemento;
}
```

### Busca posição do elemento
```
public int BuscaPosicao(T elemento){
    for(int i = 0; i < this.tamanho; i++){
        if(this.elementos[i].Equals(elemento)){
            return i;
        }
    }

    return -1;
}
```

### Contains elemento no vetor
```
public bool Contains(T elemento){
    for(int i = 0; i < this.tamanho; i++){
        if(this.elementos[i].Equals(elemento))
            return true;
    }

    return false;
}
```

### Busca elemento pela posição
```
public T Busca(int posicao){
    if(posicao < 0 || posicao >= this.tamanho){
        throw new Exception("Posição inválida.");
    }

    return this.elementos[posicao];
}
```

### Busca o tamanho do vetor
```
public int GetTamanho(){
    return this.tamanho;
}
```

### Lista todos os elementos do vetor
```
public void ListaElementos(){
    for(int i = 0; i < this.tamanho; i++){
        Console.WriteLine(this.elementos[i]);
    }
}
```
