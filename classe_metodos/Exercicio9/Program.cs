using RespostaExercicio9;

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("\nEscolha uma cor, selecionando seu respectivo número: ");
int valor = Convert.ToInt32(Console.ReadLine());

var cor = (Cores)valor;
Console.WriteLine($"A cor escolhida foi {cor}");

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
    int Cor;

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia, int Cor = 1)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = Cor;
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

    public struct Cliente
    {
        public string Nome;
        public string Email;
        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 18)
                {
                    idade = 18;
                    Console.WriteLine("O cliente menor que 18 anos");
                }
                else
                {
                    Console.WriteLine("O cliente é maior que 18 anos");
                    idade = value;
                }
            }
        }

        public Cliente(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        public static void ExibirInfo(string nome, string email, int idade = 18)
        {
            Console.WriteLine($"{nome} - {email} - {idade}");
        }
    }

}