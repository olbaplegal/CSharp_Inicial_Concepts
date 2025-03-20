//4 - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero
//recebido via teclado 

while (true)
{
    Console.WriteLine("\nDigite um número para ver sua tabuada (n!=0)(999=exit)");
    short n = Convert.ToInt16(Console.ReadLine());

    if (n == 999)
        break;

    //tabuada
    if (n != 0)
    {
        for (short i = 1; i < 11; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }

    if (n == 0)
        Console.WriteLine("número invalido, tente outro...");
}
Console.WriteLine("fim do programa");
