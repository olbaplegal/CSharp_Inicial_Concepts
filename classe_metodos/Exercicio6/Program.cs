Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.WriteLine($"{carro1.Modelo} {carro1.Montadora} {carro1.Marca}" +
$" {carro1.Ano} {carro1.Potencia} ");
carro1.Acelerar(carro1.Marca);

Carro.ObterValorIpva();

Console.WriteLine($"Valor do Ipva: {Carro.ValorIpva} %");

//O modificador static permite declarar um membro estático que pertence ao próprio tipo e não a um objeto
//específico.Ele pode ser usado para declarar classes, structs e interfaces.
//Nas classes, structs e interfaces podemos usar o modificador static para campos, métodos, propriedades,
//operadores, eventos e construtores.

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public static double ValorIpva;

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }
    public void Acelerar(string marca)
    {
        Console.WriteLine($"\nAcelerando o meu {marca} vrum vrum...\n");
    }
    public double Acelerar(int potencia)
    {
        return potencia * 1.75;
    }
    public int AumentarPotencia(int potencia)
    {
        return potencia + 3;
    }
    public int AumentarPotencia(ref int potencia)
    {
        return potencia + 5;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 123)
    {
        Console.WriteLine($"{modelo}\t{montadora}\t{marca}\t{potencia}\t{ano}");
    }

    public static void ObterValorIpva()
    {
        ValorIpva = 4;
    }
}