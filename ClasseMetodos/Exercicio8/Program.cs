//Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
//Console.WriteLine($"{carro1.Modelo} {carro1.Montadora} {carro1.Marca}" +
//$" {carro1.Ano} {carro1.Potencia} ");
//carro1.Acelerar(carro1.Marca);

using static Carro;

Cliente cliente = new("Maria", "maria@email.com", 19);
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, idade: cliente.Idade);
Console.WriteLine("\nExibindo informação sem informar a idade");
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);

//As structs são usadas para estruturar dados comuns em um mesmo contexto e são semelhantes as classes.
//São definidas usando a palavra-chave struct.
//    A principal diferença é que as structs são tipos de valor, alocados na Stack enquanto as classes são tipos de
//referência, alocados na heap e coletadas pelo coletor de lixo (Garbage Collector).
//Uma struct é útil para situações nas quais precisamos de poucas variáveis, pois os objetos criados com base
//em structs são mais leves e por ser do tipo de valor não trabalham com referências e são desalocadas da
//memória Stack após sua utilização



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