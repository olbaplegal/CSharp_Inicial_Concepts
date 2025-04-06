using SerializacaoXMLExercicio;
using System.Xml.Serialization;

List<Aluno> alunos = new List<Aluno>
{
    new Aluno(10, "Maria", "maria@yahoo.com", 17),
    new Aluno(11, "Olbap", "olbap@yahoo.com", 19),
    new Aluno(12, "Pablo", "pablo@yahoo.com", 21),
};

string caminhoArquivo = @"D:\Dev\dados-teste\AlunosSerializadosLista.xml";

// Corrigido aqui
XmlSerializer serializer = new XmlSerializer(typeof(List<Aluno>));

using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, alunos);
}
Console.WriteLine("fim do programa");
Console.ReadKey();
