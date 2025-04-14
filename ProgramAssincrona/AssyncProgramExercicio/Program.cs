await ExecutaOperacaoAsync();

Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //criar um CancellationTokenSource que vai ser cancelada após um especifico timespan(nesse caso 10)
    var tempo = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando download...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

	try
	{
		using var httpClient = new HttpClient();//assim que tarminar de usar essa instancia ela vai ser liberada
		var destino = "D:\\Dev\\dados-teste\\arquivo.txt";//destino do arquivo

		var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt",
							 HttpCompletionOption.ResponseHeadersRead,
							 cancellationTokenSource.Token);
		var totalBytes = response.Content.Headers.ContentLength;//armazenando em bytes o conteudo do arquivo lido, ultilizado para monitorar o processo da leitura
		var readBytes = 0L;

		await using var fileStream = new FileStream(destino, FileMode.Create,//await vai esperar a operação acabar e o using vai matar a operação apos o uso
													FileAccess.Write);
		await using var contentStream = await response.Content
										.ReadAsStreamAsync(cancellationTokenSource.Token);

		var buffer = new byte[81920];
		int bytesRead;

		while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length,
							cancellationTokenSource.Token))>0)
		{
			await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
			readBytes += bytesRead;
            Console.WriteLine($"progresso: {readBytes}/{totalBytes}");
		}
	}
	catch (OperationCanceledException ex)
	{
		if (cancellationTokenSource.IsCancellationRequested)
		{
            Console.WriteLine("\ndownload cancelado por tempo limite: " + ex.Message );
		}
		else
		{
            Console.WriteLine("\no tempo limite para o donwload foi atingido.");
		}
	}
	catch (HttpRequestException ex)
	{
        Console.WriteLine($"\nocorreu um erro de rede: {ex.Message}");
	}
	catch (Exception ex)
	{
        Console.WriteLine($"\nocorreu um erro desconhecido: " + ex.Message);
	}
	finally
	{
        Console.WriteLine("donwload finalizado.");
	}
}