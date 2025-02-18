using System.Collections;

//declarar uma coleão do tipo List<T>
List<string> lista;
lista = new List<string>();

List<int> lista1 = new List<int>();

var lista2 = new List<float>();

List<double> lista3 = new();

List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Maria");

var lista4 = new List<string>()
{
    "Paulo", "Maria", "Bia", "Pedro"
};

//criação da lista

var lista0 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

//"Add" adiciona ao final da lista
lista.Add("Marta");

//"Insert" adiciona no indice escolhido
lista.Insert(2, "Bia");

//criação de uma collection
string[] array1 = new string[] { "Dina", "Carlos", "Pedro" };

//adicionando coleção ao final da lista
lista.AddRange(array1);

//adicionando coleção em um indice expecifico
lista.InsertRange(1, array1);

//removeu o dado "Dina"
lista.Remove("Dina");

//removendo dado no indice 4
lista.RemoveAt(4);

//removendo dados do indice 0 até o 2
lista.RemoveRange(0, 2);

//acessando um elemento da lista usando indice
var primeiro = lista[0];
var quarto = lista[3];

Console.WriteLine(lista[0]);
Console.WriteLine(lista[3]);
//console.WriteLine(lista[9]);

//da pra usa o for e o foreach da mesma forma que se usaria em um array

//verifica se tem o valor especificado na lista, retorna Bolean
var res1 = lista.Contains("Ana");

//remove todos os elementos da lista
lista.Clear();

//comparação, ArrayList && List<T>
//boxing == transformar um tipo primitivo em obj
//quando você introduz um dado de tipo primitivo em um ArrayList você faz boxing do dado
ArrayList lista11 = new ArrayList();
lista1.Add(3);//boxing
lista1.Add(4);//boxing

var elemento = lista1[0];//unboxing //ta retornado um obj
int numero = (int)lista1[1];//tem que fazer a converção explicita

List<int> lista22 = new();
lista2.Add(2);

var item = lista2[0];

Console.ReadKey();

