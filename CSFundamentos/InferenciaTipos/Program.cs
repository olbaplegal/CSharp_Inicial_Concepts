Console.WriteLine("## Inferencia de Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")} reais por mês.");

//var limitações
var salario = null
var titulo;
var salario, imposto, total;

//não pode mudar o tipo após inicializar
var num = 10;
num = num + 20;
num = "teste";

var teste = new Teste();
teste.MeuMetodo();




Console.ReadKey();

class Teste
{
    public void MeuMetodo() 
    {
        Console.WriteLine("Meu Método!");
    }
}