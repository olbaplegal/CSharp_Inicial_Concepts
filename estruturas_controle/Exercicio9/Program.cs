//9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

//for (int m1 = 1; m1 < 7; m1++)
//{
//    for (int n = 1; n < 11; n++)
//    {
//        Console.WriteLine($"{m1} x {n} = {m1 * n}");
//    }
//    Console.WriteLine();
//}

int n = 1, m = 1;
do
{
    n = 1;
    do
    {
        Console.WriteLine($"{m} x {n} = {n * m}");
        n++;
    }
    while (n < 11);
    m++;
    Console.WriteLine();
}
while (m < 7);