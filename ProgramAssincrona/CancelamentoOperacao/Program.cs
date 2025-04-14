public static Main(string[] args)
{

}

Task task = Task.Run(() =>
{
    Console.WriteLine("iniciando tarefa...");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"executando tarefa... {i + 1}");
        Task.Delay(1000).Wait();
    }
    Console.WriteLine("tarefa concluida");
});
private static Task<int> OperacaoLongaDuracao(int valor)
{
    return Task.Run(() =>
    {
        int resultado = 0;
        for (int i = 0; i < valor; i++)
        {
            Thread.Sleep(50);
            resultado += i;
        }
        return resultado;
    });
}
//Task.Run();
//|tipos usados para realizar o cancelamento|
//CancellationTokenSource
//CancellationToken
//OperationCanceledException