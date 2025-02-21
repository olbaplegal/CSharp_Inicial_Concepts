using System.Threading.Channels;

Console.WriteLine("## Instrução if-else ##\n");

//Console.WriteLine("informe a nota do aluno \t");
//var nota = Convert.ToInt32(Console.ReadLine());
//if (nota > 5)
//    Console.WriteLine("aprovado");
//else
//    Console.WriteLine("aluno reprovado");
//Console.WriteLine("fim do processo");

Console.WriteLine("informe o valor de x");
int x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("informe o valor de y");
int y = Convert.ToInt16(Console.ReadLine());

if (x > y)
    Console.WriteLine("x é maior que y");
else
    if (y > x)
    Console.WriteLine("y é maior que x");
else
    Console.WriteLine("x e y são iguais");

Console.WriteLine("fim do processamento");

Console.ReadKey();