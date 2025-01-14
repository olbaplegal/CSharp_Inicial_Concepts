Console.WriteLine("## assinatura de método - sobrecarga ##\n");

Email email = new();

email.Enviar("empresa.com.br");
email.Enviar("empresa.com.br", "Proposta Comercial");
email.Enviar("empresa.com.br", "Proposta Comercial");
email.Enviar("empresa.com.br", 2000);
email.Enviar(2000, "empresa.com.br");

Console.ReadLine();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão");
    }

    public void Enviar(string endereco, string assunto)//mudou os parâmetros
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine($"{valor}");
    }
    public void Enviar(decimal valor, string endereco)//ordem dos parametros alterada
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}