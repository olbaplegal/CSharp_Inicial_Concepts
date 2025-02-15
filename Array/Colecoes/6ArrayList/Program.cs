using System.Collections;

ArrayList lista;
lista = new ArrayList();

ArrayList lista1 = new ArrayList();
var lista2 = new ArrayList();
ArrayList lista3 = new();

ArrayList lista4 = new ArrayList(5);
var lista5 = new ArrayList(5);
ArrayList lista6 = new(5);

ArrayList lista7 = new();

lista7.Add("Paulo");
lista7.Add(4.5);
lista7.Add(5);
lista7.Add(true);
lista7.Add(" ");
lista7.Add(null);

var lista8 = new ArrayList() { "Paulo", 4.5, 5, " ", null };

Console.ReadKey();
Console.Clear();

var lista9 = new ArrayList() { "Maria", 5, true, " ", null };

lista9.Add(5.3);
lista9.Insert(2, "Paulo0");

Console.ReadKey();
Console.Clear();

var lista10 = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista.AddRange(array1);

lista.InsertRange(2, array1);

Console.ReadLine();
Console.Clear();

var lista11 = new ArrayList() { "Paulo", 4.5, 5, " ", null, true, 2, 6, 0 };

lista.Remove(null); // remove pelo valor do indice

lista.RemoveAt(4); // remove pelo número do indice

lista.RemoveRange(0, 2); // remove 2 ou mais elementos, aonde é primeiro espaço é aonde vai começar

