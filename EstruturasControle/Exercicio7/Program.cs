//7 - Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*).
void piramide(int linhas)
{
    for (int i = 1; i <= linhas; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
piramide(5);

