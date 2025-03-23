// coleção generica Dictionary 

Dictionary<int, int> dic1 = new Dictionary<int, int>(); // Tkey de valor int e TValue de valor int

var dic2 = new Dictionary<int, int>();

dic2.Add(2, 100);
dic2.Add(4, 400); 
dic2.Add(3, 300);

var dic3 = new Dictionary<int, int>()
{
    {1,100 },
    {2,200 },
    {3,300 }
};

Console.WriteLine("\n-Incluir elemento com chave(3) duplicada");
try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); // mostra a mensagem de descreve a excessão
    Console.WriteLine(ex.ToString); // cria e retorna uma representação da excessão 
}

var resultado = dic3.TryAdd(3, 333); // TryAdd tenta adicionar Key e Value à coleção
Console.WriteLine("elemento foi incluido? " + resultado);

Console.WriteLine("\nIncluindo o elemento com chave 7 e valor 7000");
if(!dic3.ContainsKey(7)) // ContainsKey retorna Boolean se key existir no Dictionary
{
    dic3.Add(7, 7000);
}
Console.WriteLine(dic3[7]);

Console.WriteLine("\n-Usando ContainsValue");
if (dic3.ContainsValue(7000)) // ConstainsValue retorna Boolean se value existir no Dictionary
{
    Console.WriteLine("O valor existe no Dicionario");
}

Console.WriteLine("\n-Alterando o valor do elemento com chave 7");
Console.WriteLine("Valor atual do item " + dic3[7]);
if (dic3.ContainsKey(7))
{
    dic3[7] = 7777; // modificando value
}
Console.WriteLine("Valor alterado do item " + dic3[7]);

Console.WriteLine("\n-Tentando obter elemento com chave(5) inexistente");

try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n-Usando TryGetValue() para a chave 7");

if (dic3.TryGetValue(7, out int valor)) // TryGetValue get the value assoated with the especified key
{
    Console.WriteLine("valor para a chave 7 = " + valor);
}
else
{
    Console.WriteLine("chave não encontrada");
}

dic3.Add(6, 6666);
dic3.Add(4, 4444);

Console.WriteLine("\n-Percorrendo o dicionário e exibindo os itens (foreach) ");
foreach (var item in dic3)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine("\n-Ordenando os elementos do dicionario(SortedDictionary/LINQ)");

// var dic3Ordenado = new SortedDictionary<int, int>(dic3); // criando dicionario ordenado a partir do meu dicionario existente 
var dic3Ordenado = dic3.OrderBy(x => x.Key); // ordenando pela chave
foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
Console.ReadKey();