# Pilhas

A pilha é uma estrutura de dados sequencial que nos permite recuperar os dados na ordem inversa à que foram inseridos. Esta restrição sobre a entrada e saída de dados na estrutura é conhecida como política de acesso e, no caso da pilha, leva o nome de <b>LIFO</b> Last In First Out (último a entrar, primeiro a sair).
```
public class Pilha<T>
{
    private T[] elements;
    private int size;

    public Pilha(int capacidade)
    {
        this.elements = new T[capacidade];
        this.size = 0;
    }

    private void increasesCapacity(){
        if(this.size+1 <= this.elements.Length)
            return;

        var novoElemento = new T[this.elements.Length + 10];

        for(var i = 0; i < this.elements.Length;i++)
            novoElemento[i] = this.elements[i];

        this.elements = novoElemento;
    }
}
```


## Principais métodos

### Push
Método que adiciona um novo item na stack
```
public void Push(T elemento)
{
    increasesCapacity();
    elements[size] = elemento;
    size++;
}
```

### Pop
Método que remove e retorna o item do top na stack
```
public T Pop()
{
    if (IsEmpty())
        throw new Exception("Pilha vazia");

    var elemento = elements[size - 1];
    size--;
    return elemento;
}
```

### Peek
Método que retorna o último item adicionado
```
public T Peek()
{
    if (IsEmpty())
        throw new Exception("Pilha vazia");

    return elements[size - 1];
}
```

### IsEmpty
Método que retorna um bool, se a stack está vazia
```
public bool IsEmpty()
{
    return size == 0;
}
```

### Size
Método que retorna a quantidade de itens na stack
```
public int Size()
{
    return size;
}
```