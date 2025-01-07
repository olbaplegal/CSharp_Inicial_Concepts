//8- Escreva um programa para calcular o fatorial de um número inteiro
int fatorial(int numero)
{
    int resultado = 1;
    for (int i = 2; i <= numero; i++)
    {
        resultado *= i;
    }
    return resultado;
}
Console.WriteLine(fatorial(1));


//if (numero == 0) return 1;

//return numero * fatorial(numero - 1);
