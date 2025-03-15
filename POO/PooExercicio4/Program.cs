using PooExercicio4;

Pessoa[] pessoas = new Pessoa[3];//iniciando matriz do tipo pessoa
Console.WriteLine("Informe o nome de 3 pessoas");//printando para informar nome de pessoas
for(int i=0;i<3;i++)
{
    pessoas[i] = new Pessoa()//instanciando um obj do tipo pessoa no indice [i] da array 
    {
        Nome = Console.ReadLine()//preenchendo atributo do obj (dentro das chaves)
    };
}

Console.WriteLine("\nAcessando os dados...\n");//printando que esta acessando dados

for(int i=0;i<3;i++)//laço for para acessar o array
{
    Console.WriteLine(pessoas[i].ToString());//ultilizando o método ToString modificado para printar a frase + nome
}

Console.ReadLine();