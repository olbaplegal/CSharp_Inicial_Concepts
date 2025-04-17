using Conjuntos2;

Console.WriteLine("hello world");

Console.ReadKey();
public class Codigos
{
    public static void Intersect()
    {
        List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

        var resultado = fonte1.Intersect(fonte2);//intersect

        foreach (var n in resultado)
        {
            Console.WriteLine(n);
        }
    }

    public static void IntersectSobrecarregado()
    {
        string[] fonte1 = { "Brasil", "USA", "UK", "Argentina", "China" };
        string[] fonte2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

        var resultado = fonte1.Intersect(fonte2, StringComparer.OrdinalIgnoreCase);

        foreach (var n in resultado)
        {
            Console.WriteLine(n);
        }
    }

    public static void IntersectBy()
    {
        var turmaA = FonteDados.GetTurmaA();
        var turmaB = FonteDados.GetTurmaA();

        var consultaSelect = turmaA.Select(p => p.Nascimento.Year)
                          .Intersect(turmaB.Select(p => p.Nascimento.Year));//ultilizando select

        var consultaIntersectBy = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento.Year),
                                          p => p.Nascimento.Year);//ultilizando intersectby

        Console.WriteLine("Turma A - Alunos com mesmo ano de nascimento da turma B\n");
        foreach (var aluno in consultaIntersectBy)
        {
            Console.WriteLine($"{aluno.Nome}");
        }

        Console.WriteLine($"\nTotal de alunos : {consultaIntersectBy.Count()}");
    }

    public static void Union()
    {
        List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

        var resultado = fonte1.Union(fonte2);//union junta os dois conjuntos ignorando as intersecções

        foreach (var n in resultado)
        {
            Console.WriteLine($"{n}");
        }
    }

    public static void UnionSobrecarregado()
    {
        string[] fonte1 = { "Brasil", "USA", "UK", "Argentina", "China" };
        string[] fonte2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

        var resultado = fonte1.Union(fonte2, StringComparer.OrdinalIgnoreCase);

        foreach (var n in resultado)
        {
            Console.WriteLine(n);
        }
    }

    public static void UnionBy()
    {
        var turmaA = FonteDados.GetTurmaA();
        var turmaB = FonteDados.GetTurmaB();

        var turmasUnionBy = turmaA.UnionBy(turmaB, p => p.Nome);

        Console.WriteLine("alunos nomes disntintos\n");
        foreach (var aluno in turmasUnionBy)
        {
            Console.WriteLine($"{aluno.Nome}/{aluno.Nascimento.Year}/{aluno.Idade}");
        }
    }
}