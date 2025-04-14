Console.WriteLine("\nIniciando a operação assíncrona...");
await MetodoSemRtornoAsync();

Console.WriteLine("\niniciando a operação assincrona...");
var resultado = await MetodoRetornaValorAsync(20);
Console.WriteLine($"resultado: {resultado}");

Console.ReadKey();

static async ValueTask MetodoSemRtornoAsync()
{
    Console.WriteLine("-Método que não retorna valor");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{
    Console.WriteLine("-Método que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}

class Calendar1
{
    public const int Months = 12;
}