//Em tempo de execução, os objetos de uma classe derivada podem ser tratados como objetos de uma classe base
using Polimorfismo;//exportando classes do arquivo atual

var figuras = new List<Figura>//criando lista de do tipo Figura
{
    new Triangulo(),//instanciando obj do tipo triangulo dentro da lista de Figuras
    new Circulo()//instanciando obj do tipo circulo dentro da lista de Figuras
};

foreach(var figura in figuras)//foreach para perpassar a lista 
{
    figura.Desenhar();//ultilizando método da classe base(isso irá acionar o método da classe derivada que foi breescrito)
}

Console.ReadKey();//it's over