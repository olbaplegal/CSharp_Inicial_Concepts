// criando uma coleção alunostionary<Tkey, TValue> para armazenas os valores
using DictionaryExercicio;
using System.Threading.Channels;

var alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 7) },
    {2, new Aluno("Eric", 8) },
    {3, new Aluno("Ana", 9) },
    {4, new Aluno("Alex", 6) },
    {5, new Aluno("Diná", 5) },
};

Aluno.ExibirColecao(alunos);

do
{
    Console.WriteLine("\ninforme o código do Aluno a localizar(99 sai)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 99)
        break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("informe a nota (1 a 10)");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("aluno não localizado");
    }
}
while (true);
Aluno.ExibirColecao(alunos);

do 
{ 

    Console.WriteLine("\ninforme o código do Aluno a remover(99 sai)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 99)
        break;
    if(alunos.ContainsKey(codigo))
    {
        alunos.Remove(codigo);
    }
    else
    {
        Console.WriteLine("aluno não localizado");
    }
}
while (true);
Aluno.ExibirColecao(alunos);

Console.WriteLine("\ninclusão de um novo aluno");
Console.WriteLine("\ninforme o nome do novo aluno");
string novoNome = Console.ReadLine();

Console.WriteLine("informe a nota do novo aluno");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o codigo do novo aluno(1 a 10)");
int novoCodigo = Convert.ToInt32(Console.ReadLine());

if (!alunos.ContainsKey(novoCodigo))
{
    alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
    Console.WriteLine("aluno incluido com sucesso");
}
else
{
    Console.WriteLine("o codigo já existe");
}
Aluno.ExibirColecao(alunos);

Console.ReadKey();

