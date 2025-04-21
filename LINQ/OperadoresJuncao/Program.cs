List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

Console.ReadKey();

class Codigos
{
    public static void ElementAt()
    {
        List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        int resultado = numeros.ElementAt(5);

        Console.WriteLine(resultado);

        //se a fonte do dado é um objeto complexo,
        //então o que vai retornar é o indice do objeto

        //ultilizando o ElementAtDefault ele retorna o valor padrão 
        //do tipo se a fonte de dado estiver vazia
    }

    public static void First()
    {
        List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        int resultado1 = numeros.First();
        int resultado2 = numeros.First(n => n > 20);//sobrecarga de método

        Console.WriteLine(resultado1);
        Console.WriteLine(resultado2);

        //pega o primeiro da fonte

        //FirstOrDefault é a mesma ideia do ElementAtOrDefualt
    }
}