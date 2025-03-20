//Escreva um programa para calcular a raiz da equação quadrática

Console.WriteLine("Digite o valor de a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de c:");
double c = Convert.ToDouble(Console.ReadLine());
//double a = 2, b = 3, c = 4;

double delta = Math.Pow(b, 2) - 4 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

double equacaoQuadratica1 = Math.Pow(a * x1, 2) + b * x1 + c;
double equacaoQuadratica2 = Math.Pow(a * x2, 2) + b * x2 + c;

if (delta > 0)
{
    Console.WriteLine($"primeira raiz = {x1}");
    Console.WriteLine($"segunda raiz = {x2}");
}
else
    Console.WriteLine("sem solução para números reais");

//Console.WriteLine(delta);
//Console.WriteLine(x1);
//Console.WriteLine(x2);
//Console.WriteLine(equacaoQuadratica1);
//Console.WriteLine(equacaoQuadratica2);



Console.WriteLine("\nfim do programa...");
Console.ReadLine();