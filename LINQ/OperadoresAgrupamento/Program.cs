using OperadoresAgrupamento;

var alunos = FonteDados.GetDados();

var grupos = alunos.GroupBy(x => new { x.Curso, x.Sexo })
                            .OrderBy(g => g.Key.Curso)
                            .ThenBy(g => g.Key.Sexo)
                            .Select(g => new
                            {
                                Curso = g.Key.Curso,
                                Sexo = g.Key.Sexo,
                                Alunos = g.OrderBy(x => x.Nome)
                            });

foreach (var grupo in grupos)
{
    Console.WriteLine($"\n{grupo.Curso} {grupo.Sexo} (alunos:{grupo.Alunos.Count()})");
    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome} {aluno.Idade} {aluno.Sexo}");
    }
}

Console.ReadKey();

class Codigos
{
    public static void GroupBy()
    {
        var alunos = FonteDados.GetDados();

        //sintaxe de método
        var grupos = alunos.GroupBy(i => i.Idade);

        Console.WriteLine("teste");

        //itera através cada aluno do grupo
        foreach (var grupo in grupos)
        {
            Console.WriteLine($"\nIdade : {grupo.Key} alunos: {grupo.Count()}");
            //itera atravez de cada aluno do grupo
            foreach (var aluno in grupo)
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.Curso} - {aluno.Sexo}");
            }
        }
    }
}