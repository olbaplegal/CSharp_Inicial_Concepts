Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" +
$" {chevrolet.Ano} {chevrolet.Potencia} ");

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
ford.Acelerar(ford.Marca);

Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca}" +
$" {ford.Ano} {ford.Potencia} ");

Console.WriteLine(ford.Acelerar(ford.Potencia));

Console.WriteLine(ford.AumentarPotencia(ford.Potencia));//passando argumentos por valor, criou uma copia desse argumento, mandou pro método, e o método retornou depois. (diferentes locais na memória)

Console.WriteLine(ford.AumentarPotencia(ref ford.Potencia));//passando argumentos por valor, quando iniciou o método criouse outra variavel no metodo que apontou para aonde estava o valor na stack 

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    //criação de obj apenas com atributos Modelo e Montadora
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
        //return ultilizado para retornar um valor do tipo especificado
    }
    public int AumentarPotencia(int potencia)
    {
        return potencia + 3;
    }
    public int AumentarPotencia(ref int potencia)
    {
        return potencia + 5;
    }
    //sobrecarga de metodos é quando o tem mais de um metodo com o mesmo nome ai eles se diferenciam pelo valor/ordem de seus parametros/tipos e ações

}