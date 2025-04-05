try
{
    Console.WriteLine("\ninforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\ninforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
}
catch (FormatException)
{
    Console.WriteLine($"\ninforme um valor inteiro");
    //Console.WriteLine($"\n{ex.Message}");//simples
    //Console.WriteLine($"\n{ex.Source}");//resumida
    //Console.WriteLine($"\n{ex.StackTrace}");//pilha
}
catch (OverflowException)
{
    Console.WriteLine("informe um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("não existe divisão por zero tente novamente");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();