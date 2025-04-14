await LancaExceptionAsync();

Console.ReadKey(); 

static async Task LancaExceptionAsync()
{
	try
	{
		var primeiraTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new IndexOutOfRangeException
			("IndexOutOfEangeException lançada explicitamente.");
		});
		await primeiraTask;
	}
	catch(Exception ex)
	{
        Console.WriteLine("Bloco catch executando");
        Console.WriteLine(ex.Message);
	}
}
//exception só será tratada se o bloco try catch for ultilizado na func async