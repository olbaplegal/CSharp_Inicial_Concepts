using DesserializacaoJSON;
using System.Text.Json;

var caminhoArquivo = @"D:\Dev\dados-teste\AlunoSerializado.json";

//lê todo o conteúdo do arquivo JSON
string jsonContent = File.ReadAllText(caminhoArquivo);//ReadAllText lê todo o conteudo do arquivo selecionado e vai armazenar em jsonContent

var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, " +
       $"Email: {aluno.Email}, Idade: {aluno.Idade}");

Console.ReadKey();

