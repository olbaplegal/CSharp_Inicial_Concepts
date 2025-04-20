namespace OperadoresQuantificacao
{
    class FonteDados
    {
        public static List<Funcionario> GetDados()
        {
            List<Funcionario> funcionarios = new ()
            {
                new Funcionario () {Nome = "Maria", Idade = 36, Salario = 3850.00m},
                new Funcionario () {Nome = "Manoel", Idade = 33, Salario = 2490.00m},
                new Funcionario () {Nome = "Amanda", Idade = 21, Salario = 5257.50m},
            };
            return funcionarios;
        }
    }
}
