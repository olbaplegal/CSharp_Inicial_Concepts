using PooExercicio3;

var pessoas = new Pessoa[3];//criando matriz com 3 indices do tipo pessoa
for(int i=0;i<3;i++)//iniciando laço de repetição para receber os inputs
{
    if(i == 0)
    {
        Console.WriteLine("Informe o nome do Professor");
        pessoas[i] = new Professor(Console.ReadLine());//criando instancia e do obj Professor dentro do indice da matriz e perguntando o nome para usar como parametro para o construtor
    }
    else
    {
        Console.WriteLine("Informe o nome do Aluno");
        pessoas[i] = new Aluno(Console.ReadLine());
    }
}
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Professor...");
        ((Professor)pessoas[i]).Explicar();//casting explicito de classe pessoa para classe profesor
    }
    else
    {
        Console.WriteLine("Aluno...");
        ((Aluno)pessoas[i]).Estudar();//casting explicito de classe pessoa para classe Aluno
    }
}
//para chamar o método de aluno/professor precisamos fazer o casting explicito ultilizando assim o método que esta somente nas classes derivadas 
