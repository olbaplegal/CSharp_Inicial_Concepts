List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

//usando predicado
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Predicado: {fruta1}");

//usando a expressão lambda
var frutas2 = frutas.Find(f => f.Contains('n'));
Console.WriteLine($"Expressão Lambda: {frutas2}");

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}

// predicado é uma função/método de argumento único que retorna um valor booleano
//lambda salva vidas