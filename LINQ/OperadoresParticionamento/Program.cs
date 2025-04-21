List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> resultado = numeros.Skip(4).ToList();

foreach (var num in resultado)
{
    Console.WriteLine($"{num}");
}

//vai pular os primeiros numeros do indica que você botou

//skipwhile passa pelos elementos se a condição for true, se for falsa
//então ele para, seu diferencial do where é que o where carrega toda a coleção
//ai se tiver um item que satisfaza a condição no final da coleção esse
//item vai ser retornado, diferente do skipwhile.

class Codigos
{
    public static void Take()
    {
        List<int> numeros1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> resultado1 = numeros1.Take(4).ToList();

        foreach (var n in resultado1)
        {
            Console.WriteLine($"{n} ");
        }

        //Take retorna a do inicio da coleção até o número especificado

        List<int> numeros2 = new List<int>() { 1, 3, 7, 10, 5, 8, 6, 9, 4, 2 };
        var resultado2 = numeros2.OrderByDescending(n => n).Take(5);
        //takewhile passa pelos elementos se a condição for true, se for falsa
        //então ele para, seu diferencial do where é que o where carrega toda a coleção
        //ai se tiver um item que satisfaza a condição no final da coleção esse
        //item vai ser retornado, diferente do takewhile.
    }
}