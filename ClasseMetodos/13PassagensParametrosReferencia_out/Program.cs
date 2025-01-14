Console.WriteLine("## argumentos por referência - out");

Console.WriteLine("informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalcularAreaPerimetro(raio, out double area);

Console.WriteLine("Perímetro da Circuferencia " + perimetro);
Console.WriteLine("Area da Circuferencia " + area);

Console.ReadLine();

public class Circulo
{
    public double CalcularAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
//dois valores em um unico metodo