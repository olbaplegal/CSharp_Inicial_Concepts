Console.WriteLine("## Entrada de Dados ##\n");

//ReadLine() lê uma única linha
//Read() lê um unico caracter e retorna em ASCII
//ReadKey() lê um unico caracter e retorna em ConsoleKeyInfo (masi ultilizado para congelar a tela)
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O seu nome é {nome} e você tem {idade} anos.");

Console.ReadKey();