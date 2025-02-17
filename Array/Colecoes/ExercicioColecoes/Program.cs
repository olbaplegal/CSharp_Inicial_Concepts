////1 >>>
//string[] frutas = new[] { "Maça", "Banana", "Lanaranja", "Uva", "Manga", "Pêra", "Abacate", "Morango", "Pêssego", "Amora" };

////1.a >>>
////for
//Console.WriteLine("Frutas usando for:");
//for (int i = 0; i < frutas.Length; i++)
//{
//    Console.WriteLine(frutas[i]);
//}
//Console.WriteLine($"Quantidade de frutas: {frutas.Length}");

////foreach
//Console.WriteLine("\nFrutas usando foreach:");
//foreach (var fruta in frutas)
//{
//    Console.WriteLine(fruta);
//}
//Console.WriteLine($"Quantidade de frutas: {frutas.Length}");

////1.b
//Console.WriteLine("\n\nSegunda e Penultima fruta:");
//Console.WriteLine($"Segunda fruta: {frutas[1]}");
//Console.WriteLine($"Penultima fruta: {frutas[8]}");

////1.c
//Console.WriteLine("\n\nTrocando frutas");
//frutas[2] = "Kiwi"; //trocando terceira fruta
//frutas[9] = "Caqui"; //trocando ultima fruta
//foreach (var fruta in frutas)
//{
//    Console.WriteLine(fruta);
//}

////1.d
//Console.WriteLine("\n\nFrutas em ordem ascendente");
//Array.Sort(frutas);
//foreach (var fruta in frutas)
//{
//    Console.WriteLine(fruta);
//}

////1.e
//Console.WriteLine("\n\nFrutas na ordem inversa");
//Array.Reverse(frutas);
//foreach (var fruta in frutas)
//{
//    Console.WriteLine(fruta);
//}

//Console.ReadLine();



////2
////solicitando número de valores do array
//Console.WriteLine("´tamanho do array");
//int i = Convert.ToInt32(Console.ReadLine());

////declarando e inicializando um array de inteiros
//int[] array = new int[i];

////botando valores do array
//Console.WriteLine("items do array");
//for (int j = 0; j < array.Length; j++)
//{
//    array[j] = Convert.ToInt32(Console.ReadLine());
//}

//string numero;
//Console.WriteLine("\nInforme o número a localizar no array (tecle fim para encerrar): \n");
//do
//{
//    numero = Console.ReadLine();

//    if (numero != "fim")
//    {
//        int valor = Convert.ToInt32(numero);

//        if (Array.BinarySearch(array, valor) >= 0)
//        {
//            Console.WriteLine($"\nO número {numero} Existe no array");
//        }
//        else
//        {
//            Console.WriteLine($"\nO número {numero} não existe no array");
//        }
//    }
//}
//while (numero != "fim");

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>3

////define os grupos
//int totalGrupo = 2;
//int totalPorGrupo = 5;

////declara e inicializa o array com os grupos
//float[,] notas = new float[totalGrupo, totalPorGrupo];

////define os valores dos totais iniciais das notas
//float totalGrupo1 = 0.0f, totalGrupo2 = 0.0f;

//Console.WriteLine("\nCálculo da média das notas de 2 grupos de alunos com 5 alunos cada");
//Console.WriteLine("Array bidimensional => [2,5]\n");

//for (int i = 0; i < totalGrupo; i++)
//{
//    Console.WriteLine($"Informe nota do grupo {i + 1}");
//    for (int j = 0; j < totalPorGrupo; j++)
//    {
//        Console.Write($"Nota : [{i},[{j}] = ");
//        notas[i, j] = Convert.ToSingle(Console.ReadLine());
//    }
//}

////Calculando a média para o grupo 1
////percorre o array
//for (int i = 0; i < totalPorGrupo; i++)
//{
//    totalGrupo1 += notas[0, i];
//}

////Exibe resultado
//Console.WriteLine($"Média para o grupo 1: {totalGrupo1 / totalPorGrupo}");

//for (int i = 0; i < totalPorGrupo; i++)
//{
//    totalGrupo2 += notas[1, i];
//}
//Console.WriteLine($"\nMédia para o grupo 2: {totalGrupo2 / totalPorGrupo}");

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>