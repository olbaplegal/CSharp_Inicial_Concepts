namespace PooExericico9
{
    class MastroCreditCard : ICartaoCredito, ITransacao
    {
        public void ValidarCartao()
        {
            Console.WriteLine("Validando Transação");
        }
        public void IniciarTransacao()
        {
            Console.WriteLine("Iniciando Transação");
        }
        public void StatusTransacao()
        {
            Console.WriteLine("Transação Completada");
        }
    }
}
