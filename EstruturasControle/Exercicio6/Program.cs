//6 - Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3
//maneiras diferentes:
//-Incrementando 2 em cada passo
//- Incrementando 1 em cada passo
//- Com e loop infinito (use "break" e "continue")

for (short i = 10; i < 21; i += 2)
{
    if (i == 16)
        continue;
    Console.WriteLine(i);
}
Console.WriteLine();

for (short i = 10; i < 21; i++)
{

    if (i % 2 == 0)
    {
        if (i == 16)
            continue;
        Console.WriteLine(i);
    }
}
Console.WriteLine();

for (short i = 8; ;)
{
    i += 2;
    if (i == 16)
        continue;
    else if (i > 20)
        break;
    Console.WriteLine(i);
}