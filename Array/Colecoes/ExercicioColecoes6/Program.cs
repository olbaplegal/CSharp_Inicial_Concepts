

ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);

Console.ReadKey();

//Método estático : permite ser invocado sem criar instância da classe
//Usa o array de parâmetros definido pela palavra-chave params
//Define uma variável chamada vetor do tipo object
//Assim pode recever tipos por valor e tipos por referência
static void ProcessaObjetos(params object[] vetor)
{
    Console.WriteLine("\nExibindo o conteúdo do array de objetos...\n");

    if (vetor != null)
    {
        foreach (object objeto in vetor)
        {
            //Estamos usando GetType() herdado dde Object
            //E usamos o operador? conhecido como "null-conditional operator"
            //ou elvis operator, que determina se valor é null; se assim for,
            //o método GetType() não será invocado e não teremos exceção
            // NullReferenceException.
            Console.WriteLine($"objeto: {objeto} \t tipo: {objeto.GetType()}");
        }
    }
}

class Teste
{ }