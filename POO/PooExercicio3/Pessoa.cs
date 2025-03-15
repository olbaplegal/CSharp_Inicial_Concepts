namespace PooExercicio3
{
    class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }

        public override string ToString()
        {
            return "Olá! meu nome é " + Nome;
        }
    }
}
