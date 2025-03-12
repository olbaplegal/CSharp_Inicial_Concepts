
using HerancaAbstract;
//não dá para instanciar a classe Forma
Quadrado q = new();
Console.WriteLine(q.Descriçao());

Console.WriteLine("\nInforme a cor da figura ");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado : {q.Area} m2");
Console.WriteLine($"\nPerimetro do quadrado : {q.Perimetro} m");

Console.WriteLine($"O quadrado tem a cor : {q.Cor}");

Console.ReadKey();