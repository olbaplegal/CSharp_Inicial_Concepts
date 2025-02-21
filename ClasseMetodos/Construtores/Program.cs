Console.WriteLine("## construtores ##");

Aluno aluno = new(22, "feminino", "aprovado");
Aluno aluno = new("maria");

//operador ternario (condição? true : false)
Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


Console.ReadKey();

public class Aluno
{

    public Aluno(string nome) => Nome = nome; //expression body 

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome) //this se refere ao construct atual
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    //ctor -> cria um construtor


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

}