await LancaMultiplasExcecoesAsync();

Console.ReadKey();

static async Task LancaMultiplasExcecoesAsync()
{
    Task? tarefas = null;
	try
	{
		var primeiraTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new IndexOutOfRangeException
			("IndexOutOfRangeException lançada explicitamente.");
		});
		var segundaTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new InvalidOperationException
			("InvalidOperationException lançada explicitamente");
		});

		tarefas = Task.WhenAll(primeiraTask, segundaTask);//when all espera todos as tasks colocadas no paremetro acabarem
		await tarefas;//await se não não pega nenhuma exceção
	}
	catch
	{
        Console.WriteLine("Ocorreram as seguintes execeções: -\n");
		AggregateException TodasExeptions = tarefas.Exception;//pegas as exceptions e botas no todasexceptions

		foreach (var ex in TodasExeptions.InnerExceptions)//dale foreach
		{
            Console.WriteLine(ex.GetType().ToString());
		}
	}
}