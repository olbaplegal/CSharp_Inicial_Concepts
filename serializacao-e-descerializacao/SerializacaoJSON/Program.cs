using SerializacaoJSON;
using System.Text.Json;

Aluno aluno1 = new Aluno(10, "Maria", "maria@yahoo.com", 17);

var caminhoArquivo = @"D:\Dev\dados-teste\AlunoSerializado.json";

using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno1);
}

Console.WriteLine("objeto serializado para JSON com sucesso!");
Console.ReadKey();