var timesSP = new HashSet<string> { "santos", "palmeiras", "são paulo" };
var timesRJ = new HashSet<string> { "vasco", "flamengo", "fluminense" };
var timesBA = new HashSet<string> { "bahia", "vitoria", "juazeiro" };
var timesMundiais = new HashSet<string> { "santos", "são paulo", "flamengo", "palmeiras" };

if (!timesSP.Contains("corinthians"))//testando para ver se o time ta no hashset
{
    //ultilisando o método Add se não existir vai adicionar a coleção e retornar true, caso exista, não vai incluir e vai retornar false
    timesSP.Add("corinthians");//true
    timesSP.Add("santos");//false
}

//var resultado = timesBA.Remove("juazeiro");//devolve true ou false se a operação foi um sucesso

//if(timesSP.IsSubsetOf(timesMundiais))//IsSubsetOff analisa se é subconjunto
//{
//    Console.WriteLine("timesSP é um subconjunto de timesMundiais\n");
//}
//if (timesMundiais.IsSupersetOf(timesSP))//IsSupersetOF analisa se é super conjunto 
//{
//    Console.WriteLine("timesMundiais é um superconjunto de timesSP\n");
//}
//if (timesRJ.Overlaps(timesMundiais))//Overlaps analisa se pelo menos tem um item em comum
//{
//    Console.WriteLine("pelo menos um time do RJ tem titulo mundial\n");
//}
//if (!timesSP.SetEquals(timesRJ))//SetEquals analisa se tem os mesmos elementos
//{
//    Console.WriteLine("timesSP e timesRJ não tem os mesmos times\n");
//}

//Console.WriteLine("\njuntando os hashset<t> : sp, rj e ba");
//timesSP.UnionWith(timesRJ);//UnionWith junta dois hashsets
//timesSP.UnionWith(timesBA);

//ExibirColecao(timesSP);

//Console.WriteLine("\njuntando os times de sp, rj, ba, ordenados");
//var todosTimes = new SortedSet<string>(timesSP);
//ExibirColecao(todosTimes);

//Console.WriteLine("\nintersecção de dois hashset<T> : timesSP e timesMundiais");
//timesSP.IntersectWith(timesMundiais);//intersectwith vai dar como resultado os elementos que são comums a sp e mundiais
//ExibirColecao(timesSP);
//Console.ReadKey();

//Console.WriteLine("\ndiferença entre dois hashset<t>: timesMundiais e timesSP");
//timesMundiais.ExceptWith(timesSP);
//ExibirColecao(timesMundiais);//deixa só a diferença

//Console.WriteLine("\ndiferença de dois hashset<t> : timesMundiais e timesSP com symmetricException");
//timesMundiais.SymmetricExceptWith(timesSP);//retorna apenas os que não estão em ambos os conjuntos
//ExibirColecao(timesMundiais);

Console.WriteLine("remove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
Console.WriteLine("fim do precessamento");
static void ExibirColecao<T>(IEnumerable<T> timesSP)//método generico estatico
{
    Console.WriteLine();
    foreach (var item in timesSP)
    {
        Console.WriteLine($"{item}");
    }
}