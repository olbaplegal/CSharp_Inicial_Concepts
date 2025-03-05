namespace HerancaExercicioV2
{
    class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009;
        public double Imposto { get; set; } = 0.001;
        private decimal CalcularImposto(double imposto)
        {
            return Saldo * (decimal)imposto;
        }
        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor + CalcularImposto(Imposto);
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente...");
                return Saldo;
            }
        }
    }
}
