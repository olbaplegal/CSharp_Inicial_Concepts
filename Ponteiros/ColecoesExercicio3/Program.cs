//define os grupos
int totalGrupo = 2;
int totalPorGrupo = 5;

//declara e inicializa o array com os grupos
float[,] notas = new float[totalGrupo, totalPorGrupo];

//define os valores dos totais iniciais das notas
float totalGrupo1 = 0.0f, totalGrupo2 = 0.0f;

Console.WriteLine("\nCálculo da média das notas de 2 grupos de alunos com 5 alunos cada");
Console.WriteLine("Array bidimensional => [2,5]\n");

for (int i = 0; i < totalGrupo; i++)
{
    Console.WriteLine($"Informe nota do grupo {i + 1}");
    for (int j = 0; j < totalPorGrupo; j++)
    {
        Console.Write($"Nota : [{i},[{j}] = ");
        notas[i, j] = Convert.ToSingle(Console.ReadLine());
    }
}

//Calculando a média para o grupo 1
//percorre o array
for (int i = 0; i < totalPorGrupo; i++)
{
    totalGrupo1 += notas[0, i];
}

//Exibe resultado
Console.WriteLine($"Média para o grupo 1: {totalGrupo1 / totalPorGrupo}");

for (int i = 0; i < totalPorGrupo; i++)
{
    totalGrupo2 += notas[1, i];
}
Console.WriteLine($"\nMédia para o grupo 2: {totalGrupo2 / totalPorGrupo}");
Console.ReadKey();