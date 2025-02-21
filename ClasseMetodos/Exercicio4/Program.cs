Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.WriteLine($"{carro1.Modelo} {carro1.Montadora} {carro1.Marca}" +
$" {carro1.Ano} {carro1.Potencia} ");

carro1.Acelerar(carro1.Marca);

int novaPotencia = carro1.AumentarPotenciaVelocidade(carro1.Potencia, out double velocidade);
Console.WriteLine($"velocidade = {velocidade}");
Console.WriteLine($"potencia = {novaPotencia}");


Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

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
        Console.WriteLine("\nAcelerando o meu " + marca);
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
}
//A palavra-chave out é usada para passar um argumento por referência igual a ref, mas o argumento pode ser
//passado sem atribuir nenhum valor a ele. Um argumento que é passado usando out deve ser inicializado no
//método chamado antes de retornar ao método chamador.
//Podemos usar a palavra-chave out para obter mais de um retorno de um método.