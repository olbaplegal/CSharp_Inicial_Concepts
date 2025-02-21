Console.WriteLine("## metodos ##");

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();

Console.ReadLine();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("bem vindo");
        ExibirDataAtual();
    }

    //expressão compacta
    public void ExibirDataAtual() =>
        Console.WriteLine(DateTime.Now.ToShortDateString);

    //top level statements
}