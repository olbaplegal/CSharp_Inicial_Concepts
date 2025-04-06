int divisor = 0;
int dividendo = 0;
try
{
    Console.WriteLine("\ninforme o dividendo");
    dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\ninforme o divisor");
    divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
}
//catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
//{
//    Console.WriteLine("\nHoje é sexta-feira e não capturamos estas exceções por motivos óbvios...\n\nsextouuuuu\n\n");
//}
catch (Exception) when ((dividendo / divisor) == 0)
{
    //este bloco nunca será alcançado pois dividendo/divisor
    //lança uma exceção e na cláusula when que será definida
    //como false e será ignorada
    Console.WriteLine("esta linha nunca será lida...");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("filtro de exceção com format");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}


Console.ReadKey();