using Conjuntos1;

Console.WriteLine("hello world");

Console.ReadKey();

public class Codigos
{
    public static void Distinct()
    {
        var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };

        //retorna os itens distintos de um vetor
        var idadesDistintas = idades.Distinct().ToArray();// => execução imediata
        //var idadesDistintas = idades.Distinct().ToList(); => execução imediata
        //var idadesDistintas = idades.Distinct(); => execução adiada (apenas quando o variavel for apresentada)

        foreach (var idade in idadesDistintas)
        {
            Console.WriteLine(idade);
        }
    }

    public static void DistinctSobrecarregado()
    {
        string[] nomes = { "Paulo", "MARIA", "paulo", "Amanda", "maria", "Amanda" };

        var nomesDistintos = nomes.Distinct(StringComparer.OrdinalIgnoreCase);//sobrecarga; disable case sensitive

        foreach (var nome in nomesDistintos)
        {
            Console.WriteLine(nome);
        }
    }

    public static void DistinctBy()
    {
        var alunos = FonteDados.GetAlunos().ToList();

        var alunosIdadeDistintas = alunos.DistinctBy(a => a.Idade);//DistinctBy retorna elementos distintos de uma sequencia de acordo com a key especificada

        foreach (var aluno in alunosIdadeDistintas)
        {
            Console.WriteLine(aluno.Nome + " | " + aluno.Idade);
        }
    }

    public static void Except()
    {
        List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

        var resultado = fonte1.Except(fonte2);//lista com somente os números que tem na fonte1 e não tem na fonte2

        foreach (var n in resultado)
        {
            Console.WriteLine(n);
        }
    }

    public static void ExceptSobrecarregado()
    {
        string[] fonte1 = { "Brasil", "USA", "UK", "Argentina", "China" };
        string[] fonte2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

        var resultado = fonte1.Except(fonte2, StringComparer.OrdinalIgnoreCase).ToList();//except sobrecarregado

        foreach (var paises in resultado)
        {
            Console.WriteLine(paises);
        }
    }

    public static void ExceptBy()
    {
        var alunos = FonteDados.GetAlunos();

        var alunosReprovados = new List<string>() { "Amanda", "Alicia", "Jaime" };

        var resultado = alunos.ExceptBy(alunosReprovados, a => a.Nome);//except sobrecarregado

        Console.WriteLine("aprovados:");
        foreach (var aprovados in resultado)
        {
            Console.WriteLine($"{aprovados.Nome} | {aprovados.Idade}");
        }
    }
}