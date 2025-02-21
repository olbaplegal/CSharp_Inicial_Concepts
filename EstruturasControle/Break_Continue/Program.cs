Console.WriteLine("## break e continue");

//for (; ; )
//{
//    Console.WriteLine("Digite alguma palavra para ver em caixa alta (X sai)");
//    string opcao = Console.ReadLine();
//    Console.WriteLine(opcao.ToUpper());

//    if (opcao == "X" || opcao == "x")
//    {
//        Console.WriteLine("até mais...");
//        break;
//    }
//}

//for (short i = 1; i <= 10; i++)
//{
//    if (i == 4)
//        continue;
//    Console.WriteLine(i);
//}

//int n = 1;
//while (n <= 10)
//{
//    if (n == 5)
//    {
//        n = n + 1;
//        continue;
//    }

//    Console.WriteLine($"n = {n}");
//    n++;
//}

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        continue;

    if (i > 8)
        break;

    Console.WriteLine(i);
}

Console.WriteLine("\n fim do programa");
Console.ReadKey();