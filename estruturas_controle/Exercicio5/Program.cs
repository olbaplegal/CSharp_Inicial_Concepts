//5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de
//resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//Não utilize a instrução break.

string r = "";

while (r != "x")
{
    Console.WriteLine("qual é a instrução para sair do loop?");
    Console.WriteLine("a.quit");
    Console.WriteLine("b.continue");
    Console.WriteLine("c.break");
    Console.WriteLine("d.exit");
    Console.WriteLine("\nqual é a opção correta? (x = sair)");
    r = Console.ReadLine().ToLower();

    if (r == "c")
        Console.WriteLine("parabens, você acertou!!\n");
    else if (r != "c")
        Console.WriteLine("que pena, você errou... tente novamente\n");
}