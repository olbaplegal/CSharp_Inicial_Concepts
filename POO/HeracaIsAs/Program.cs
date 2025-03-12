Object carroObj = new Carro();

var x = carroObj as string; //com operador "as" se não conseguir converter, vai transformar em null

if(x != null)
{
    Console.WriteLine("converteu obj para string");
}
else
{
    Console.WriteLine("Não  foi possivel converter, x é null");
}

class Carro
{}

// "is" verifica se a obj é derivado, se for, retorna true, se não, false