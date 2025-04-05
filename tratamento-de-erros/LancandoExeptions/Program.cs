//Console.WriteLine("Antes de lançar a exception");

//throw new Exception("Lançando uma exceção manualmente");

//Console.WriteLine("depois de lançar  a exception");
try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\ntratando o erro em Main\n ");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
//o throw mantém a hierarquia de exceções no rastreamento da pilha e fornece informações completas enquanto que usar o throw ex retorn as exceções até o ponto no qual o código throw ex foi executado, ai, os detalhes são removidos da exceção até este ponto

Console.ReadKey();
class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex;//perdeu o bloco de exceções anteriores
            Console.WriteLine("Tratando o erro em A");
        }
    }
}
class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            throw;
            Console.WriteLine("tratando o erro em B");
        }
    }
}
class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}