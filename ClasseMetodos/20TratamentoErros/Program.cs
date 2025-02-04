Console.WriteLine("divisão de números inteiros");
Console.WriteLine("x / y");

Console.WriteLine("\nInform o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInform o valor de y");
int y = Convert.ToInt32(Console.ReadLine());








try
{
    int z = x / y;
    Console.WriteLine($"\n{x} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("Não existe divisão por 0, tente outro número...");

    Console.WriteLine($"\n Erro: << {ex.Message} >>");
    Console.WriteLine($"\n Detalhes {ex?.StackTrace.ToString()}");
}
finally
{
    Console.WriteLine("Processamento concluido ");
}

Console.ReadLine();