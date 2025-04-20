using OperadoresQuantificacao;









Console.ReadKey();

class Codigos
{
    public static void All()
    {
        //all retorna se tiver todos
        int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };
        var resultado = numeros.All(n => n % 2 == 0);

        Console.WriteLine($"{(resultado ? "todos são pares" : "nem todos são pares")}"); //op ternario

        var funcionarios = FonteDados.GetDados();

        var todosSalariosAcima2500 = funcionarios.All(f => f.Salario > 2500.00m);
        var todosMaiorQue21 = funcionarios.All(i => i.Idade > 21);
        var todosNomesContemLetraA = funcionarios.All(a => a.Nome.Contains('a'));

        Console.WriteLine($"{todosSalariosAcima2500} - {todosMaiorQue21} - {todosNomesContemLetraA}");
    }

    public static void Any()
    {
        //any retorna se tiver pelo menos 1
        //primeira sobrecarga
        string[] cursos = { "C#", "Java", "Phyton", "PHP", "ASP.NET", "Node" };
        var existemCursos = cursos.Any();

        var existemCursosMaiorQue2 = cursos.Any(c => c.Length > 2);

        Console.WriteLine($"{existemCursos} - {existemCursosMaiorQue2}");
    }

    public static void Contains()
    {
        int[] numeros = { 3, 5, 7, 9, 10, 12, 15, 20, 300, 39 };
        var resultado = numeros.Contains(12);
        Console.WriteLine(resultado);
        //contem dispensa explicações
    }
}