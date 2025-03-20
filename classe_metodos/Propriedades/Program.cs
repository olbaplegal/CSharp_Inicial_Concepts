Console.WriteLine("## propriedades ##");

Produto p1 = new();
p1.Nome = "caderno";
p1.Preco = 10.00;
p1.Desconto = 0.05;
p1.PrecoFinal = p1.Preco - p1.Desconto;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();


public class Produto
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public double Desconto { get; set; }
    public double PrecoFinal { get; set; }
    public int EstoqueMinimo { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto} \n{PrecoFinal.ToString("c")} \n{EstoqueMinimo}");
    }
}