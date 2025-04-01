using Vetores;

var vetor = new Vetor<string>(5);
vetor.Adiciona("elemento 2");
vetor.Adiciona("elemento 4");
vetor.Adiciona("elemento 5");
vetor.ListaElementos();
Console.WriteLine("Adicona posição:");
vetor.Adiciona(0,"elemento 1");
vetor.ListaElementos();
Console.WriteLine("Adicona posição:");
vetor.Adiciona(2,"elemento 3");
vetor.ListaElementos();


Console.WriteLine("aumenta capacidade:");
vetor.Adiciona("elemento 6");
vetor.Adiciona("elemento 7");
vetor.ListaElementos();

Console.WriteLine("Remove elemento em posição:");
vetor.Remove(vetor.BuscaPosicao("elemento 2"));
vetor.ListaElementos();

Console.WriteLine(vetor.GetTamanho());

Console.WriteLine("Elemento contains");
Console.WriteLine(vetor.Contains("elemento 60"));
