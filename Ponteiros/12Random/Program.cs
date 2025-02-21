
Random random = new(2023);

Console.WriteLine(random.Next()); //número aleatorio definido no intervalo dos números inteiro
Console.WriteLine(random.Next(20)); //no maximo 20
Console.WriteLine(random.Next(10, 20)); //entre 10 e 20
Console.WriteLine(random.NextDouble()); //entre 0 e 1
Console.WriteLine();

byte[] randBytes = new byte[10];
random.NextBytes(randBytes);
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(randBytes[i]);
}

Console.WriteLine("\n\n\nSorteio da MegaSena\n");

int[] numerosSorteados = new int[6];


for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Numeros Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados)); //método join contatena os elementos de um array usando um separador especifico

Console.ReadKey();