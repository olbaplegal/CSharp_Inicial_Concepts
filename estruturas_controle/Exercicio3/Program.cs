//3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
//while, do-while e for.

//while
short n = 0, sum = 0;
while (sum < 55)
{
    n++;
    sum += n;
    Console.WriteLine(n);
}
Console.WriteLine(sum);

//do-while
n = 0; sum = 0;
do
{
    n++;
    sum += n;
    Console.WriteLine(n);
} while (n < 10);
Console.WriteLine(sum);

//for
for (n = 1, sum = 0; sum < 55; n++)
{
    sum += n;
    Console.WriteLine(n);
}
Console.WriteLine(sum);