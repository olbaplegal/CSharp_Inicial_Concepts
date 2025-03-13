namespace Polimorfismo
{
    class Figura//classe base
    {
        public virtual void Desenhar()//ultilizando virtual para indicar que este método poderá ser reescrito em outras classes posteriormente
        {
            Console.WriteLine("Executando Desenhar na classe base");//print 
        }
    }
}
