using Agregacao2;

Max();

Console.ReadKey();


class Codigos
{
    public static void Count()
    {
        string[] cursos = { "C#", "Java", "Phyton", "PHP", "Go", "ASP.NET", "Node" };

        var resultado1 = cursos.Count();

        Console.WriteLine(resultado1);

        //Count com filtro
        var resultado2 = cursos.Count(c => c.Contains('P'));

        Console.WriteLine(resultado2);
    }
    public static void Sum()
    {
        int[] numeros = { 3, 5, 7, 9, 10, 12, 15, 12, 30, 39 };
        int resultado = numeros.Sum(n =>
        {
            if (n > 10)
                return n;
            else
                return 0;
        });
        Console.WriteLine(resultado);
    }
    public static void Max()
    {
        int[] numeros = { 3, 5, 7, 9, 10, 12, 15, 12, 30, 39 };

        var maior = numeros.Max();
        Console.WriteLine(maior);
        //Min é a mesma ideia
    }
}