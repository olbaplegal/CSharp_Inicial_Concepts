//1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

Console.WriteLine("Digite 3 números:");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"{n1} é o maior número");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"{n2} é o maior número");
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"{n3} é o maior número");
}
else
{
    Console.WriteLine("são iguais");
}

Console.WriteLine("\nfim do programa");
Console.ReadKey();