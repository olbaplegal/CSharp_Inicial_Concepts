Console.WriteLine("## Saída de dados: Formatação ##");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

//escrever na mesma linha "Maria tem 25 anos"
Console.WriteLine(nome);
Console.WriteLine(" tem ");
Console.WriteLine(idade);
Console.WriteLine( "anos" );
Console.WriteLine();

//usar a concatenação: usando o perador +
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.WriteLine();

//usar a interpolação de strings : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine();

//usar place holders : usa {} com numeração com inicio em 0 
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadKey();