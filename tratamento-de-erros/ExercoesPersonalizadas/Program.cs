using ExercoesPersonalizadas;

try
{
    Conta conta1 = new Conta(100, "Maria", 100m);
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    
}
//criar uma classe de exceção separada para cada condição de erro que deseja manipular. isso torna mais fácil identificar e lidar com exceções específicas em seu código.
//substitua a propriedade Message para fornecer uma mensagem de erro significativa que descreva a condição de erro. Esta mensagem será exibida quando a exceção for lançada.
//substitua o método ToString() para retornar uma representação de string da exceção, que pode ser útil para fins de log e depuração.
//adicione propriedades ou métodos adicionais necessários à sua classe de execeção personalisada para fornecer mais informaçãoes sobre a condição de erro.
//faça o possivel para não lançar exceptions 
Console.ReadKey();
public class Conta
{
    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: {valor}");
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        Console.WriteLine($"Sacou: {valor}");
        if (Saldo < valor)
            throw new SaldoInsuficienteException(valor,Saldo);
        Saldo -= valor;
        return Saldo;
    }
    public override string ToString()
    {
        return $"Conta : {Numero} : {Titular} - Saldo={Saldo}";
    }
}