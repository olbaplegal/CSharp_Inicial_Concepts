var numeros = new HashSet<int> { 1, 2, 3, 4, 5 };

var frutas = new HashSet<string> { "Banana", "Abacaxi", "Pera" };

HashSet<int> pares = new HashSet<int>();

for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}

//construtor usando IEnumerable
var lista1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var conjunto = new HashSet<int>(lista1);