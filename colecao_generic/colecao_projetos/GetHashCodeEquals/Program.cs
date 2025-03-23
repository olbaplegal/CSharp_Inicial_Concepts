string a = "José";
string b = "José";

int x = 100;
int y = 100;

Console.WriteLine(a.Equals(b));
Console.WriteLine(x.Equals(y));

var pessoa1 = new Pessoa(1, "Ana"); // true
var pessoa2 = new Pessoa(1, "Ana"); // true

Console.WriteLine(pessoa1.Equals(pessoa2)); // false

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());
Console.WriteLine(pessoa1.GetHashCode());
Console.WriteLine(pessoa2.GetHashCode());


Console.ReadKey();

public class Pessoa
{
    public Pessoa(int id, string? nome)
    {
        id = id;
        nome = nome;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
}