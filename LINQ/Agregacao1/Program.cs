using Agregacao1;

Console.WriteLine("hello world");

Console.ReadKey();

class Codigos
{
    public static void Agregator()
    {
        string[] cursos = { "C#", "Java", "Phyton", "PHP", "GO" };
        string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);
        Console.WriteLine(resultado);

        int[] numeros = { 1, 2, 3, 4, 5, 6 };
        int resultadonumeros = numeros.Aggregate((s1, s2) => s1 * s2);
        Console.WriteLine(resultadonumeros);

        //agregator é uma função acumuladora, você declara duas variaveis
        //nos parametros e depois bota uma lambda com  o prmeiro valor(que vai ser os valor
        //base) += segundo valor da para fazer varias coisas com isso, junção de string,
        //soma/multiplicação/outras operações de uma lista de números
    }

    public static void AgregatorComplexos()
    {
        var alunos = FonteDados.GetAlunos();

        string listaAlunos = alunos.Aggregate<Aluno, string>(
                                    "Nomes: ", //valor semente
                                    (semente, aluno) => semente += aluno.Nome + ", ");
        //depois de definir a semente ele só vai contatenar os nome à string semente

        int indice = listaAlunos.LastIndexOf(",");
        listaAlunos = listaAlunos.Remove(indice);

        Console.WriteLine(listaAlunos);
    }

    public static void AgregateTerceiraSobrecarga()
    {
        var alunos = FonteDados.GetAlunos();

        string listaAlunos = alunos.Aggregate<Aluno, string, string>(
                                    "Nome: ",//semente 
                                    (semente, aluno) => semente += aluno.Nome + ", ",
                                    resultado => resultado.Substring(0, resultado.Length - 2));

        Console.WriteLine(listaAlunos);
    }
    public static void Average()
    {
        var alunos = FonteDados.GetAlunos();

        var mediaIdades = alunos.Average(a => a.Idade);

        Console.WriteLine(mediaIdades);
    }
}