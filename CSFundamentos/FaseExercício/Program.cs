using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("## Exercício 1 ##\n");

//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine(idade);

//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor
string nome1 = "Maria";
Console.WriteLine(nome1);

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45
double altura = 3.45;
Console.WriteLine(altura);

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999,09,04);
Console.WriteLine(data);

//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ano = 12;
Console.WriteLine(ano);

//6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine(nota);

//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?
//Os tipos de valores estão guardados na memória stack e os tipos de referencia estão
//guardados na memoria heap, ou seja, enquanto uma foi criada do zero, a outra está
//se referenciando a uma variavel já existente.

//8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
int x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = false;
string nome = "Manoel";
decimal salario = 950.99m;
DateTime hoje = DateTime.Now;

//9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência(R) :
//(V) int n = 1;
//(R) string titulo = "A vida";
//(V) float f = 12.45f;
//(V) double d = 5.45;
//(V) decimal valor = 10.99m;
//(V) char sexo = ‘M’;
//(R) object o = null;

//10- O que é um nullable type e qual a sua utilidade ?
//nullable type é ultilizado para declarar valores nullos ou distintos, ele é frequentemente ultilizado para armazenar valores que podem estar em falta
//como quando você esta puxando informações do banco de dados.

//11- O que é Camel Case ? Dê um exemplo de sua aplicação.
//Camel Case é um método de boas praticas de programação para melhor visualizar o nome das váriaveis
// string primeiroNome = "joão"

//12- O que é Pascal Case ? Dê um exemplo de sua aplicação
//Pascal Case é um método de boas praticas de programação para melhor visualizar o nome das classes/structs etc

//13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
//seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)
int x1 = 77, y1 = 66;
int soma = x1 + y1;

//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
bool v1 = false;
char v2 = '\0';
int v3 = 0;
double v4 = 0;
float v5 = 0;
decimal v6 = 0;
string v7 = "";

//15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:
//(F) double 1valor = 12.45;
//(F) string #nome = "Pedro";
//(V) float _temperatura = 12.45f;
//(F) double int = 5;
//(F) decimal renda extra = 91.45m;
//(F) bool status$conta = false;
//(V) string titulo3 = “Tópico 1”;
//(V) float salario_mensal = 1999.55f;
//(V) int percentualValorDesconto = 5;
//(V) const bool MENSALIDADE_EM_DIA = true;

Console.ReadKey();

