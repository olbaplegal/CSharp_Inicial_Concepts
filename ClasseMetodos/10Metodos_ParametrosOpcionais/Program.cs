Console.WriteLine("## parâmetros opcionais ##\n");

Console.WriteLine("destino");
var destino = Console.ReadLine();
Console.WriteLine("titulo");
var titulo = Console.ReadLine();
Console.WriteLine("assuto");
var assunto = Console.ReadLine();

Email email = new();
email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "destino padrão", string titulo = "titulo padrão", string assunto = "assunto padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}