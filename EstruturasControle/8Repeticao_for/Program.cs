Console.WriteLine("## instrução for ##\n");

Console.WriteLine("digita um número para ver sua tabuada (>0)");
short numero = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

if (numero > 0)
{
    for (; numero <= 10; numero++)
        //Console.WriteLine($"{numero} x {i} = {i * numero}");
        Console.WriteLine(numero);
}
else
{
    Console.WriteLine("número inválido");
}

Console.WriteLine("fim do programa");
Console.ReadLine();