Console.WriteLine("## campos estáticos ##");

//A a1 = new();
//a1.x = 10;

//A a2 = new();
//a2.x = 20;

//A.y = 30;

//Console.WriteLine($"a1.x = {a1.x}, a2.x = {a2.x}, A.y = {A.y}");

//Console.ReadKey();

//public class A
//{
//    public int x;
//    public static int y;
//    //...
//}

ContaCorrente c1 = new();
c1.Conta = 101;
c1.Nome = "Maria";
//c1.Juros = 3.99f;

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 102;
c2.Nome = "Marta";
//c2.Juros = 4.99f;

ContaCorrente.Juros = 4.25f;

Console.WriteLine($"Cliente : {c1.Nome} - Jutos Anual : {c1.JurosAnual()}");
Console.WriteLine($"Cliente : {c2.Nome} - Jutos Anual : {c2.JurosAnual()}");

Console.ReadLine();
public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}