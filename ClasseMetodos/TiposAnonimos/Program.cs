var aluno = new
{
    Nome = "Maria",
    idade = 18
};

//Propriedades do tipo anônimo são somente leitura

//Console.WriteLine(aluno.GetType().ToString());
//Console.WriteLine(aluno.Nome + " - " + aluno.idade);

var aluno1 = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "Jairo@email.com",
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};

Console.WriteLine(aluno1.Nome);
Console.WriteLine(aluno1.Endereco.Cidade);