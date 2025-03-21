Teste teste = new Teste();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

teste.Comparar(i1, i2);
teste.Comparar(f1, f2);
teste.Comparar(s1, s2);
teste.Comparar(i1, f2);

Console.WriteLine();

public class Teste
{
    public void Comparar<T1, T2>(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
    //public void Comparar(float p1, float p2)
    //{
    //    var resultado = p1.Equals(p2);
    //    Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    //}
    //public void Comparar(string p1, string p2)
    //{
    //    var resultado = p1.Equals(p2);
    //    Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    //}
}