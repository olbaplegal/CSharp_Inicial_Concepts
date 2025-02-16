namespace ColecoesExercicio
{
    internal class _1
    {
        //1 >>>
        string[] frutas = new[] { "Maça", "Banana", "Lanaranja", "Uva", "Manga", "Pêra", "Abacate", "Morango", "Pêssego", "Amora" };

        //1.a >>>
        //for
        Console.WriteLine("Frutas usando for:");
for (int i = 0; i<frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}
    Console.WriteLine($"Quantidade de frutas: {frutas.Length}");

//foreach
Console.WriteLine("\nFrutas usando foreach:");
foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}
Console.WriteLine($"Quantidade de frutas: {frutas.Length}");

//1.b
Console.WriteLine("\n\nSegunda e Penultima fruta:");
Console.WriteLine($"Segunda fruta: {frutas[1]}");
Console.WriteLine($"Penultima fruta: {frutas[8]}");

//1.c
Console.WriteLine("\n\nTrocando frutas");
frutas[2] = "Kiwi"; //trocando terceira fruta
frutas[9] = "Caqui"; //trocando ultima fruta
foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

//1.d
Console.WriteLine("\n\nFrutas em ordem ascendente");
Array.Sort(frutas);
foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

//1.e
Console.WriteLine("\n\nFrutas na ordem inversa");
Array.Reverse(frutas);
foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.ReadLine();
    }
}
