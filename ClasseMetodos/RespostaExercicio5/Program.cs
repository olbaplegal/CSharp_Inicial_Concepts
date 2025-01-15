Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.WriteLine($"{carro1.Modelo} {carro1.Montadora} {carro1.Marca}" +
$" {carro1.Ano} {carro1.Potencia} ");
carro1.Acelerar(carro1.Marca);

carro1.ExibirInfo(modelo: carro1.Modelo, montadora: carro1.Montadora, marca: carro1.Marca, potencia: carro1.Potencia, ano: carro1.Ano);
carro1.ExibirInfo(modelo: carro1.Modelo, montadora: carro1.Montadora, marca: carro1.Marca, potencia: carro1.Potencia);

//argumentos nomeados, é quando você especifica qual argumento sera direcionado para qual parametros, assim você pode botar os argumentos em qualquer ordem que eles ainda
//vão ser direcionados para os argumentos certos. sintaxe => parametro : argumento

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

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 123)//parametro opcionais, é quando você define um parametro com um valor padrão,
                                                                                                      //ai você não precisa atribuir um valor a ele necessariamente.
    {
        Console.WriteLine($"{modelo}\t{montadora}\t{marca}\t{potencia}\t{ano}");
    }
}