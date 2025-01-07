Console.WriteLine("## Instrução While ##\n");

//Console.WriteLine("Digite um número para ver sua tabuada (>0)");
//double n = Convert.ToDouble(Console.ReadLine());
//short multiplicador = 1;

//if (n > 0)
//{
//    Console.WriteLine($"tabuada do {n}");
//    while (multiplicador < 11)
//    {
//        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
//        multiplicador++;
//    }
//}
//else
//{ Console.WriteLine("número inválido..."); }

//while (true)
//{
//    Console.WriteLine("Digite um número inteiro (digite 999 para sair)");
//    short n = Convert.ToInt16(Console.ReadLine());

//    if (n == 999)
//    { break; }

//    if (n % 2 == 0)
//    { Console.WriteLine("O número é par\n"); }

//    else
//    { Console.WriteLine("O número é impar\n"); }
//}

//short x = 0;
//while (x < 5)
//{
//    short y = 0;
//    while (y < 5)
//    {
//        Console.Write($"({x},{y}) ");
//        y++;
//    }

//    x++;
//    Console.WriteLine();
//}

//var i = 1;

//do
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//    if (i > 7)
//        break;
//}

//while (i <= 10);

short x = 0;
do
{
    short y = 0;
    do
    {
        Console.Write($"({x},{y})");
        y++;
    }
    while (y < 5);
    Console.WriteLine();
    x++;
}
while (x < 5);

Console.WriteLine("\nfim do programa");
Console.ReadLine();