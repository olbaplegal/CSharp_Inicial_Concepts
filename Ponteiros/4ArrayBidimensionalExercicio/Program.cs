string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine(($"Indorme o valor para o elemento na posição [{i}, {j}]"));
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteudo do Array alunos \n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"[{i}, {j}] = {alunos[1, j]}\t");
    }
}

Console.ReadKey();