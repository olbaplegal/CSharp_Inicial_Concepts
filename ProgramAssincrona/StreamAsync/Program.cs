using System.Runtime.CompilerServices;

await foreach(var mes in GeraMeses())
{
    Console.WriteLine(mes);
}

Console.ReadLine();

static async IAsyncEnumerable<string> GeraMeses()//IAsyncEnumerable
{
    yield return "janeiro";
    yield return "fevereiro";
    await Task.Delay(2000);
    yield return "março";
    yield return "abril";

}