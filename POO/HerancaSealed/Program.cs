
using System.Threading.Channels;

Console.ReadKey();

//sealed class Pessoa //não deixa outras classes derivarem dela
//{   
//    public string? Nome { get; set; }
//    public void ExibeNome()
//    {
//        Console.WriteLine($"Nome: {Nome}");
//    }
//}

//class Cliente
//{
//    public new void ExibeNome()
//    {
//        //Console.WriteLine($"\nNome do cliente {Nome}");
//    }
//}

class ClasseBase
{
    protected virtual void Metodo1() //metodos com modificador protected podem apenas ser acessados apenas pela propria classe ou derivados
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1() //sealed impede que o metodo seja sobescrito posteriormente 
    {
        Console.WriteLine("Classe1.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }
}

class Classe2 : Classe1
{
    protected override void Metodo1() //não conseguiu sobescrever por causa do sealed
    {
        Console.WriteLine("Classe1.Metodo1()");
    }
}