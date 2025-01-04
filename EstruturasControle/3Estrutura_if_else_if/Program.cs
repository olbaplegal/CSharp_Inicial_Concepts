Console.WriteLine("## Instrução if-else-if ##\n");

Console.WriteLine("Informe a nota do aluno\t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("ALUNO REPROVADO");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("ALUNO EM RECULPERAÇÃO");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("ALUNO APROVADO");
}
Console.WriteLine("fim do processo");

Console.ReadKey();