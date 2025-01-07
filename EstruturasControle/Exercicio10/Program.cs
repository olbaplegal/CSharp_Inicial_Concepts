//10 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de
//um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a
//instrução switch, break e default em um loop infinito e defina uma condição de saida.)


while (true)
{
    Console.WriteLine("\ndigite a nota do aluno (999=sai)");
    short n = Convert.ToInt16(Console.ReadLine());

    if (n == 999)
        break;

    switch (n)
    {
        case 10:
            Console.WriteLine("A+");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 8:
        case 7:
            Console.WriteLine("B");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            Console.WriteLine("F");
            break;
        default:
            Console.WriteLine("nota inválida");
            break;
    }
}
Console.WriteLine("fim do programa");