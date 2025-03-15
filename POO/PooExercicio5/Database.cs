namespace PooExercicio5
//Database é uma classe abstrata, ou seja, ela não pode ser instanciada diretamente. Soomente classes que a hedram podem ser instanciadas.
{
    abstract class Database//CLASSES ABSTRATAS NÃO PODEM SER INSTANCIADAS
    {
        public virtual void Conectar()//método virtual que vai ser sobreescrito depois
        {
            Console.WriteLine("Conectando ao banco de dados...");
        }
        public abstract void Configurar();//MÉTODO ABSTRATO, OU SEJA, A CLASSE DERIVADA DEVE SER IMPLEMENTADA
    }
}
