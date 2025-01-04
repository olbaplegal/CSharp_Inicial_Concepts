Console.WriteLine("## Estrutura switch-case ##");

//int compra = 600;
//Console.WriteLine($"valor da compra {compra:c}");
//Console.WriteLine("informe o número de parcelas (1 a 3)");
//var numeroParcelas = Convert.ToInt32(Console.ReadLine());

//switch (numeroParcelas)
//{
//    case 1:
//        Console.WriteLine($"\nprestação R$ {compra / numeroParcelas}");
//        break;
//    case 2:
//        Console.WriteLine($"\nprestação R$ {compra / numeroParcelas}");
//        break;
//    case 3:
//        Console.WriteLine($"\nprestação R$ {compra / numeroParcelas}");
//        break;
//    default:
//        Console.WriteLine("\nvalor invalido, informe 1, 2 ou 3");
//        break;
//}
//Console.WriteLine("fim do processo");

Console.WriteLine("informe o nome do mês");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("este mês tem 30 dias");
        break;
}

Console.WriteLine("\nfim do processo");
Console.ReadLine();