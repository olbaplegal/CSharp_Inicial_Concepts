Console.WriteLine("## Instrução if ##");

Console.WriteLine("O cliente é especial? (S/N)");
var resposta = Console.ReadLine();

if (resposta == "S")
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento");

Console.WriteLine("informe o valor de x");
int x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("informe o valor de y");
int y = Convert.ToInt16(Console.ReadLine());

if (x > y)
    Console.WriteLine("x é maior que y");
if (x < y)
    Console.WriteLine("y é maior que x");
if (x == y)
    Console.WriteLine("x e y são iguais");
Console.ReadKey();