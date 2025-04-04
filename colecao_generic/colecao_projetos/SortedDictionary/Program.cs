var americaLatina = new SortedDictionary<int, string>//criação do sorted dictionary 
{
    {1, "United States" },
    {2, "Bolivia" },
    {3, "Argentina" },
    {4, "Chile" },
    {5, "Colômbia" },
    {6, "Costa Rica" },
    {7, "Cuba" },
    {8, "Equador" },
    {9, "El Salvador" },
};

foreach(var pais in americaLatina)//foreach para perpassar todos os itens 
{
    Console.WriteLine($"{pais.Key} - {pais.Value}");
}

americaLatina.ContainsKey(1);//vê se tem a key
americaLatina.ContainsValue("United States");//vê se tem o valor
americaLatina.Add(10, "Guatemala");//adicionado um item ao dictionary
Console.WriteLine($"numero de chaves {americaLatina.Count}");//conta o número de chaves
americaLatina[1] = "Brasil";//troca de valores
americaLatina.Remove(4);//removendo chave/valor
if(americaLatina.TryGetValue(6, out string? valor))//vê se tem a chave e atribui o valor dela para uma variavel por referencia
    Console.WriteLine($"valor da chave 6: {valor}");
else 
    Console.WriteLine("A chave não existe");//se não tiver a chave cai nesse else

foreach(var pais in americaLatina)//foreach para perpassar todos os itens
{
    Console.WriteLine($"{pais.Key} - {pais.Value}");
}