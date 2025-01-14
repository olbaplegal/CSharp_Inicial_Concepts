Console.WriteLine("## Passando argumentos por valor ##\n");

int x = 20;
Console.WriteLine("o valor de x antes de passar pelo o metodo é " + x);

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\neste é o valor de x depois de passar pelo método dobrar " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)//y recebeu uma copia do valor 20, mas isso não afetou o argumento x
    {
        y *= 2;
        Console.WriteLine("\no valor do parâmetro y no método dobrar " + y);
    }
}

//ordem de processo =>
//criou um espaço na memoria stack com a variavel x com valor 20
//depois iniciou o método
//e criou outra variavel chamada y com uma copia do valor de x (20)
//apos o encerramento do processo, a variavel y e seu valor são apagados da memória stack