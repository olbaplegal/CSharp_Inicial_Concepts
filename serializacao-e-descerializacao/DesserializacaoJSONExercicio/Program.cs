using DesserializacaoJSONExercicio;
using System.Text.Json;

var caminhoArquivo = @"D:\Dev\dados-teste\AlunosSerializadosLista.json";

string jsonContent = File.ReadAllText(caminhoArquivo);

var alunos = JsonSerializer.Deserialize<List<Aluno>>(jsonContent);

foreach (var aluno in alunos)
{
    Console.WriteLine($"Aluno desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, " +
        $"Email: {aluno.Email}, Idade: {aluno.Idade}");
}

Console.ReadKey();