
Console.WriteLine("## classes e métodos");
//atributos (dados:propriedades, campos)
//comportamentos(métodos)

int x = 100;

//p1 é chamado objeto do tipo pessoa
//p1 é uma instancia da classe pessoa
//new = operador
Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 23;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.nome = "Manuel";
p2.idade = 23;
p2.sexo = "masculino";

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Console.ReadLine();

//declaração de classe no final do código
class Pessoa
{
    //atributos
    //atributos são representados por campos
    //comportamentos por metódos
    public string? nome;
    public int idade;
    public string? sexo;
}

//cachorro real -> classe cachorro 
//abstração -> encapsulamento