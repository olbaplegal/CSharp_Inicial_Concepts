Console.WriteLine("## Argumentos nomeados ##\n");

Email email = new();

email.Enviar("teste@email.com", "reunião de orçamento", "urgente");

//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "reunião orçamento");
email.Enviar(assunto: "reunião orçamento", destino: "teste@email.com", titulo: "Urgente");
email.Enviar(destino: "teste@email.com", titulo: "Urgente", assunto: "reunião orçamento");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}