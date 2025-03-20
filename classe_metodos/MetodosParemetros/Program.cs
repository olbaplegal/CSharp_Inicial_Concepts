Console.WriteLine("## métodos & parametros");

MinhaClasse minhaClasse = new MinhaClasse();


var nomeCliente = "Olbap";
var dataAtual = DateTime.Now;

minhaClasse.MeuMetodo(nomeCliente, dataAtual); //argumentos

Console.ReadLine();

public class MinhaClasse
{
    public void MeuMetodo(string nome, DateTime data) //parametros
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}