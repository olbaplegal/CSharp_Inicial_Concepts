Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.WriteLine($"{carro1.Modelo} {carro1.Montadora} {carro1.Marca}" +
$" {carro1.Ano} {carro1.Potencia} ");
carro1.Acelerar(carro1.Marca);

carro1.Ano = 1999;
Console.WriteLine(carro1.Ano);

//As propriedades permitem que uma classe exponha uma forma pública de obter e definir valores, enquanto
//oculta o código de implementação ou de verificação.
//Um campo é uma variável de qualquer tipo que é declarada diretamente na classe
//Uma propriedade é um membro que fornece um mecanismo flexível para ler, gravar ou calcular o valor de um
//campo privado.

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2020)
                ano = 2020;
            else
                ano = value;
        }
    }
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