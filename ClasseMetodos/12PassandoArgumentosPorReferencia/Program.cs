Console.WriteLine("## Passando argumentos por referência ##");

int x = 20;
Console.WriteLine("o valor de x antes de passar pelo o metodo é " + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\neste é o valor de x depois de passar pelo método dobrar " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\no valor do parâmetro y no método dobrar " + y);
    }
}
//ultilizando o ref voce passa para o metodo, não um copia de X, mas sim
//a referencia da area da memoria de aonde aquele valor está

//as alterações feitas no parâmetro afetam o argumento

//uso da palavra-chave ref para passar o argumento por referência