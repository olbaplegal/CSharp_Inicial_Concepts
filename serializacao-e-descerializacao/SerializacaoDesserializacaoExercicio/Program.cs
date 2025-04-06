using SerializacaoDesserializacaoExercicio;
using System.Text.Json;

//serialização JSON
List<Aluno> alunos = new List<Aluno> 
{ 
    new Aluno(10, "Maria", "maria@yahoo.com", 17),
    new Aluno(11, "Olbap", "olbap@yahoo.com", 19),
    new Aluno(12, "Pablo", "pablo@yahoo.com", 21),
};

var caminhoArquivo = @"D:\Dev\dados-teste\AlunosSerializadosLista.json";

using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, alunos);
}

Console.WriteLine("processo concluido com sucesso!");
Console.ReadKey();

