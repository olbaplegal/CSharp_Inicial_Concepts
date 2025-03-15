using PooExercicio7;

namespace PooExercicio7
{
    class Exibir : INota1, INota2
    {
        void INota1.Classificacao()
        {
            Console.WriteLine("Classificacao INota1");
        }
        void INota2.Classificacao()
        {
            Console.WriteLine("Classificacao INota1");
        }
    }
}

//class Exibir : INota1, INota2
//{
//    public void Classificacao()
//    {
//        Console.WriteLine("Classificacao INota1");
//    }
//    public void Classificacao()
//    {
//        Console.WriteLine("Classificacao INota1");
//    }
//}

//o codigo dado acima não ia dar certo pois as duas interfaces tinham o método com o mesmo nome, isso geraria ambiguidade na hora da compilação
//de tal forma se duas interfaces tiverem o mesmo contrato, a implementação da classe precisa de um indenrificador de interface(INota1.Método) e isso será feito realizando a implementação explícita de interface conforma mostrado no código.