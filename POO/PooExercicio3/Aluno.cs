namespace PooExercicio3
{
    class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)//criando construtor da classe filha chamando construtor da classe pai
        {
            Nome = nome;
        }
        public void Estudar()//método de ação do aluno
        {
            Console.WriteLine("Estudando...");
        }
    }
}
