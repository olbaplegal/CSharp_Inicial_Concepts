//string[] nomes = new string[5];

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine($"\nDigite o nome do {i + 1} aluno: ");
//    nomes[i] = Console.ReadLine();

//    //string? nome = Console.ReadLine();
//    //nomes[i] = nome;
//}

//double[] notas = new double[5];

//for (int i = 0; i < notas.Length; i++)
//{
//    Console.WriteLine($"\nDigite a nota do aluno {nomes[i]}");
//    notas[i] = Convert.ToDouble(Console.ReadLine());
//}

////acessando e exibindo os nomes dos alunos
//Console.WriteLine("\n\nAlunos: ");
//foreach (string nome in nomes)
//{
//    Console.Write($"{nome} ");
//}

////acessando e exibindo os nomes dos alunos
////var somaNotas = 0.0;
////var totalNotas = notas.Count(); //método count conta o número de indices que tem no array
//Console.WriteLine("\n\nNotas: ");
//foreach (double nota in notas)
//{
//    //somaNotas += nota;
//    Console.Write($"{nota} ");
//}

//Console.WriteLine("\nMédia das notas dos alunos foi: ");
////mediaAritmetica = totalNotas/somaNotas
//var media = notas[0] + notas[1] + notas[2] + notas[3] + notas[4];
//media = media / 5;
//Console.WriteLine(media);

//Console.ReadKey();

string[] nomes = new string[5];
double[] notas = new double[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"{i + 1}º nome: ");
    nomes[i] = Console.ReadLine();
}
Console.WriteLine();

for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"{i + 1}º nota: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();

foreach (string nome in nomes)
{
    Console.Write($"{nome}, ");
}
double tot = 0;
Console.WriteLine();

foreach (double nota in notas)
{
    Console.Write($"{nota}, ");
    tot += nota;
}
Console.WriteLine();

double media = tot / notas.Length;

Console.WriteLine($"A média das notas é {media}");