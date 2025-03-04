var gato = new Gato();
gato.Nome = "Bichano";
gato.ExibeNome();

var cachorro = new Cachorro();
cachorro.Nome = "Dogão";
cachorro.ExibeNome();

Console.ReadLine();

//classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome() //virtual indica um método a ser reescrito
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome() //override reescreve o método assinalado com virtual
    {
        Console.WriteLine($"Eu sou um gato meu nome é {Nome}");
    }
}

class Cachorro : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"Eu sou um cachorro meu nome é {Nome}");
    }
}


