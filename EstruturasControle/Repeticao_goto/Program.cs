Console.WriteLine("## estrutura de repetição com goto/label ##\n");

int i = 1;

repetir: //label

Console.WriteLine($"i={i}");
i++;

if (i <= 10)
    goto repetir;

Console.WriteLine("fim do processamento...");
Console.ReadLine();