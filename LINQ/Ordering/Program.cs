using Ordering;

Console.WriteLine("hello world");

class Codigos
{
    public static void OrdeBy()
    {
        var lista = FonteDados.GetAlunos();

        var OrderBy = lista.OrderBy(a => a.Nome);

        Console.WriteLine("OrderBy:");
        foreach (var nome in OrderBy)
        {
            Console.WriteLine($"{nome.Nome}");
        }

        Console.WriteLine("\nOrderByDescending:");

        var OrderByDescending = lista.OrderByDescending(a => a.Nome);

        foreach (var nome in OrderBy)
        {
            Console.WriteLine($"{nome.Nome}");
        }

        var lista2 = lista.Where(p => p.Nome.Contains("r")).OrderBy(p => p.Nome);

        Console.WriteLine("OrderBy ultilizando Where");
        foreach (var nome in lista2)
        {
            Console.WriteLine(nome.Nome);
        }

        var OrderByThenBy = lista.OrderBy(p => p.Nome).ThenBy(p => p.Idade);

        Console.WriteLine("\nOrderByThenBy:");
        foreach (var n in OrderByThenBy)
        {
            Console.WriteLine($"{n.Nome} | {n.Idade}");
        }
    }

    public static void reverse()
    {
        int[] numeros = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };

        var lista = numeros.Reverse();

        Console.WriteLine("reverse:");
        foreach (var n in lista)
        {
            Console.WriteLine(n);
        }

        List<string> nomes = new List<string>(){"Pedro", "Tania", "Amaral",
                                        "Penita", "Debora"};

        IEnumerable<string> reverse = nomes.AsEnumerable().Reverse();

        Console.WriteLine("reverse IEnumerable:");
        foreach (var nome in reverse)
        {
            Console.WriteLine(nome);
        }
    }
}

