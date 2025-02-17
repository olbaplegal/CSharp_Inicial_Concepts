namespace ExercicioColecoes4
{
    internal class Pessoa
    {
        //propriedades
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public string Exibir()
        {
            return Nome + " - " + Idade;
        }
    }
}
