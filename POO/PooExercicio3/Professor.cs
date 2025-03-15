namespace PooExercicio3
{
    class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            Nome = nome;
        }
        public void Explicar()//método para de ação do professor
        {
            Console.WriteLine("Explicando...");
        }
    }
}
