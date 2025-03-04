Aluno aluno = new();
aluno.Nome = "pablo";
aluno.Curso = "Eng. Software";
Console.WriteLine(aluno.Saudacao());

Console.ReadLine();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, meu nome é {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi, meu nome é {Nome} do curso {Curso}"; //saudação substituiu o saudasão da classe base
}
//new sinaliza que você realmente quer substituir o método da classe base.