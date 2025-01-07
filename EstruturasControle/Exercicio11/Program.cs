//11 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números
//inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e
//quando isso ocorrer exibir uma mensagem de alerta)

double n1 = 3;
double n2 = 7;
string res = "/";
switch (res)
{
    case "+":        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");        break;    case "-":        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");        break;    case "*":        Console.WriteLine($"{n1} x {n2} = {n1 * n2}");        break;    case "/":        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");        break;}