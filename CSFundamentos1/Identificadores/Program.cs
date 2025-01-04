Console.WriteLine("Definindo Indentificadores\n");

//identificadoers válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//identificadores inválidos
//int 5idade;
//int $valor;
//int valor$total;
//int valor#total;
//string nome Completo;

//para nomes variáveis : camel case
string descontoTotal;
string desconto_Total;

//constantes maiuscúlas
double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";

Console.ReadLine();

//para nomes de classes e métodos: pascal case
class ImprimirTexto 
{
    public void ImprimirNome()
    {
        Console.WriteLine("Olbap");
    }
}   