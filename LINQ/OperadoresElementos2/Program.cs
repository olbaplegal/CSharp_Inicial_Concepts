List<int> numeros1 = new List<int>() { 10, 20, 30 };
IEnumerable<int> resultado1 = numeros1.DefaultIfEmpty();
foreach (var n in resultado1)
{
    Console.WriteLine(n);
}

List<int> numeros2 = new List<int>() {};
IEnumerable<int> resultado2 = numeros2.DefaultIfEmpty();
foreach (var n in resultado2)
{
    Console.WriteLine(n);
}

List<int> numeros3 = new List<int>() { };
IEnumerable<int> resultado3 = numeros3.DefaultIfEmpty(69);
foreach (var n in resultado3)
{
    Console.WriteLine(n);
}

//se tiver dado não faz nada
//se não tiver dado retorna valor padrão do tipo
//se quiser pode modificar o valor padrão

class Codigos
{
    public static void Last()
    {
        List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        var resultado1 = numeros.Last();
        var resultado2 = numeros.Last(n => n > 40);

        Console.WriteLine(resultado1);
        Console.WriteLine(resultado2);

        //LastOrDefault adicionar valor padrão do tipo se o dado estiver vazio
    }

    public static void Single()
    {
        List<int> numeros1 = new List<int>() { 10 };
        int resultado = numeros1.Single();
        Console.WriteLine(resultado);

        List<int> numeros2 = new List<int>() { 10, 20, 30 };
        var resultado2 = numeros2.Single(n => n > 20);
        Console.WriteLine(resultado2);

        List<int> numeros3 = new List<int>() { 10, 20, 30 };
        var resultado3 = numeros3.Single(n => n > 10);//vai dar pau pq tem mais de um item que satisfaz a condição
        Console.WriteLine(resultado3);

        List<int> numeros4 = new List<int>() { };
        var resultado4 = numeros4.Single();//vai dar pau pq não vai retornar nada da coleção
        Console.WriteLine(resultado4);

        //o SingleOrDefault faz com que não lance exceção caso a coleção esteja vazia
        //mas ainda vai lançar exceção caso a coleção tenha mais de um item no retorno
    }
}