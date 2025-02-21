namespace ExercicioColecoes7;

public class Aluno
{
    //define os limites do array
    string[] valor = new string[10];

    public string this[int numero]
    {
        get
        {
            // Será invocado quando acessarmos
            // instâncias da classe Aluno com []
            if (numero >= 0 && numero < valor.Length)
            {
                // retorna o valor armazenado
                return valor[numero];
            }
            // Retorna um erro
            return "Erro";
        }
        set
        {
            // Será invocado quando atribuímos valores
            // a instâncias de Aluno com []
            if (numero >= 0 && numero < valor.Length)
            {
                // atribui valor ao elemento
                valor[numero] = value;
            }
        }
    }
}
