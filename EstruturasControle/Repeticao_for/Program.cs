Console.WriteLine("## loop for ##\n");

//for(iniciador; condição; interador)

//for (int i = 0, j = 0; i + j <= 20; i++, j++)
//{
//    Console.WriteLine($"i = {i} e j = {j}");
//}

//int i = 1;
//for (; i <= 10;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//int i = 1;
//for (; ; )
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

for (short x = 0; x <= 5; x++)
{
    for (short y = 0; y <= 5; y++)
    {
        Console.Write($"({x},{y})");
    }
    Console.WriteLine();
}

Console.WriteLine("\nfim do programa");
Console.ReadLine();