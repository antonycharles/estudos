using Pilhas;

var pilha = new Pilha<int?>(5);

Console.WriteLine("Topo: " + pilha.Peek());
pilha.Push(1);
pilha.Push(3);
pilha.Push(5);

pilha.Read();

Console.WriteLine("Tamanho: " + pilha.Size());
Console.WriteLine("Topo: " + pilha.Peek());
Console.WriteLine("Desempilhando: " + pilha.Pop());
Console.WriteLine("Tamanho: " + pilha.Size());
pilha.Read();