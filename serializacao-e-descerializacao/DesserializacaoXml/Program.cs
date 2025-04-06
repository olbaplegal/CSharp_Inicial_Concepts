using SerializacaoXML;
using System.Xml.Serialization;


string caminhoArquivo = @"D:\Dev\dados-teste\AlunoSerializado.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));//cria uma instancia de XmlSerializer chamada serializer, passando o tipo do objeto que eu to serializando

using (StreamReader reader = new StreamReader(caminhoArquivo))//usando o StreamReader para ler
{
    var aluno = (Aluno)serializer.Deserialize(reader);//ultilizando o método Deserializer() para desserializar o objeto selecionado e armazena no aluno

    Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, " +
        $"Email: {aluno.Email}, Idade: {aluno.Idade}");
}

Console.ReadKey();