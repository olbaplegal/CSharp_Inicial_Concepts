Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine(chevrolet.Modelo);
Console.WriteLine(chevrolet.Montadora);
Console.WriteLine(chevrolet.Marca);
Console.WriteLine(chevrolet.Ano);
Console.WriteLine(chevrolet.Potencia);
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine(ford.Modelo);
Console.WriteLine(ford.Montadora);
Console.WriteLine(ford.Marca);
Console.WriteLine(ford.Ano);
Console.WriteLine(ford.Potencia);
ford.Acelerar(ford.Marca);

Carro ford2 = new("SUV", "Ford");
Console.WriteLine(ford2.Modelo);
Console.WriteLine(ford2.Montadora);
Console.WriteLine(ford2.Marca);
Console.WriteLine(ford2.Ano);
Console.WriteLine(ford2.Potencia);

Console.ReadKey();

public class Carro
{
    public Carro(string Mdelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    //cria carros apenas com modelo e montadora
    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}...\n");
    }

    public double VelociadadeMaxima(int potencia)
    {
        return Potencia * 1.75; //return é usado para retornar algo no método
    }
}