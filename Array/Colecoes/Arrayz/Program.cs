//declaração do array
int[] numeros;

//aloquei memória
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = new string[5] { "Maria", "Ana", "João", "Felipe", "Carlos" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"índice {i}, elemento {numeros[i]}");
}
Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{i} ; {nomes[i]}");
}
Console.WriteLine();

foreach (var item in numeros)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

foreach (var item in nomes)
{
    Console.Write($"{item} ");
}