using Projecao;

List<List<int>> listas = new List<List<int>>
{
    new List<int> {1, 2, 3},
    new List<int> {12},
    new List<int> {5, 6, 5, 7},
    new List<int> {10, 12, 12, 13},
};

IEnumerable<int> resultado = listas.SelectMany(lista => lista.Distinct());
foreach (var i in resultado)
    Console.Write($"{i} ");

//select produz um valor de resultado para cada valor de origem
//selectMany produz um unico resultado que tem o valor contatenado

Console.ReadLine();

class Exemplos
{
    public void Exemplo1()
    {
        //seleciona todos os dados originais
        IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();//ToList() cria a consulta e retorna os dados de imediato

        foreach (var aluno in alunos)
            Console.WriteLine($"{aluno.Nome} : {aluno.Nota}");

        //selecionar apenas o nome
        IEnumerable<string> nomesAlunos = FonteDados.GetAlunos().Select(a => a.Nome);

        foreach (var nome in nomesAlunos)
            Console.WriteLine($"{nome}");
    }
    public void Exemplo2()
    {
        List<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
        {
            Nome = a.Nome,
            Idade = a.Idade
        }).ToList();
        Console.WriteLine("Alunos Idade");
        foreach (var aluno in lista)
            Console.WriteLine($"{aluno.Nome} : {aluno.Idade}");
    }
}