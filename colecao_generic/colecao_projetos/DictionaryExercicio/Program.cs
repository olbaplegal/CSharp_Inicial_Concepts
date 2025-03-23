// criando uma coleção alunostionary<Tkey, TValue> para armazenas os valores
using DictionaryExercicio;

var alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 7) },
    {2, new Aluno("Eric", 8) },
    {3, new Aluno("Ana", 9) },
    {4, new Aluno("Alex", 6) },
    {5, new Aluno("Diná", 5) },
};

// acessando e exibindo os nomes e as notas dos alunos
Console.WriteLine("\nNomes - Notas");
foreach (var item in alunos)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

// localizando e atualizando a nota do aluno Diná
alunos[5].Nota = 8;
Console.WriteLine("\nNomes - Notas");
foreach (var item in alunos)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

// removendo um aluno da coleção
alunos.Remove(2);
Console.WriteLine("\nNomes - Notas");
foreach (var item in alunos)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

//adicionando novo aluno: Vilma - 7
alunos.Add(6, new Aluno("pablo", 2));


//ordenandoo os alunos por nome na coleção
var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);
Console.WriteLine("\nNomes - Notas");
foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

// removendo todas as keys e values
alunos.Clear();
Console.WriteLine("\nNomes - Notas");
foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}