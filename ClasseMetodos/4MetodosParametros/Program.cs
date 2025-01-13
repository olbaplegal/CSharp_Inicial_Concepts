Console.WriteLine("## métodos - parâmetros ##");

Aluno aluno1 = new();
aluno1.Consultar();

Console.WriteLine(aluno1);

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno);
    }

}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\n O aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
            Console.WriteLine("\n foi aprovado");
        else
            Console.WriteLine("\n foi reprovado");
    }
}