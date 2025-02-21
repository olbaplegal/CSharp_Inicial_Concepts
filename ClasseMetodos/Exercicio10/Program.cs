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

    static Carro()
    {
        ValorIpva = 4;
    }
    //substituir método por construtor estático
    //public static void ObterValorIPVA()
    //{
    // ValorIpva = 4;
    //}

    //- Alterar o modificador de acesso do campo estático ValorIpva para internal não traria nenhuma alteração na
    //execução do programa pois ele vai continuar sendo acessível no mesmo assembly.Agora o campo não vai estar
    //mais acessível fora do assembly.
    //- Alterar o modificador de acesso do campo estático ValorIpva para internal vai fazer com que ele seja acessível
    //somente dentro da classe Carro.

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