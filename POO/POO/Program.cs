

Funcionario funci = new();
funci.Nome = "José";
funci.Email = "jose@email.com";
funci.Empresa = "Google Inc.";
funci.Salario = 9000;

Console.WriteLine("Funcionario");
funci.Identificar();
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);

Aluno aluno = new();
aluno.Nome = "João";
aluno.Email = "joão@email.com";
aluno.Curso = "Engenharia";
aluno.Nota = 9;

Console.WriteLine("\nAluno");
aluno.Identificar();
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);

Console.ReadLine();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}

//Reutilizaçãoo de código, com a herança da pra criar classe com atributos e métodos
//compartilhados, isso evita a duplicação de código
//Especialização, permite criar atributos e comportamentos específicos, isso permite
//cirar hierarquias de classes que representam diferentes níveis de especialização.
//Extensibilidade, estende o comportamento de uma classse sem afetar outras partes
//de código que dependem dela.
//Encapsulamento, a herança pode ser combinada com o conceito de modificadores de acesso
