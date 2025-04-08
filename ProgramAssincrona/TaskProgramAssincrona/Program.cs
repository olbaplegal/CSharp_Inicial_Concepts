Console.WriteLine("tecle algo para iniciar...");
Console.ReadKey();

await Aguardar(5); //aguarda a finalização de uma tarefa

Console.WriteLine("já passou 5 segundos...\n");
Console.WriteLine("fim");
Console.ReadLine();

Console.ReadKey();

static async Task Aguardar(int tempo) //ultilizando Task para retornar para o await no main
{
    Console.WriteLine("iniciando espera...");
    await Task.Delay(TimeSpan.FromSeconds(tempo)); //await para continuar a para fazer a main roda idependente
    Console.WriteLine("Fim da espera...");
}