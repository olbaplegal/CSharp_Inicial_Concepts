//solicitando número de valores do array
Console.WriteLine("´tamanho do array");
int i = Convert.ToInt32(Console.ReadLine());

//declarando e inicializando um array de inteiros
int[] array = new int[i];

//botando valores do array
Console.WriteLine("items do array");
for (int j = 0; j < array.Length; j++)
{
    array[j] = Convert.ToInt32(Console.ReadLine());
}

string numero;
Console.WriteLine("\nInforme o número a localizar no array (tecle fim para encerrar): \n");
do
{
    numero = Console.ReadLine();

    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        if (Array.BinarySearch(array, valor) >= 0)
        {
            Console.WriteLine($"\nO número {numero} Existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} não existe no array");
        }
    }
}
while (numero != "fim");
Console.ReadLine();