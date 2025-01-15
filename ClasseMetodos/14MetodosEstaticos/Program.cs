Console.WriteLine("## Metodos Estaticos ##");

//Calculadora calc = new();

// o metodo não pertence mais a instancia e sim a classe, assim para ultilizalo, precisa mencionar a classe apenas
var soma = Calculadora.Somar(10, 10);
var subracao = Calculadora.Subtrair(10, 10);
var multiplicacao = Calculadora.Multiplicar(10, 10);
var divisao = Calculadora.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

public class Calculadora
{
    //esses metodos são chamados metodos de instancia, por que precisa ser criado uma instancia para ultilizar eles
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
