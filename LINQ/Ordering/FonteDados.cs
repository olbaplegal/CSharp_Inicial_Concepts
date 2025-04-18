namespace Ordering
{
    class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome = "Maria", Idade = 20 },
                new Aluno() { Nome = "Manoel", Idade = 22 },
                new Aluno() { Nome = "Miriam", Idade = 21 },
                new Aluno() { Nome = "Matilda", Idade = 21 },
                new Aluno() { Nome = "Jaime", Idade = 36 },
                new Aluno() { Nome = "Debora", Idade = 33 },
                new Aluno() { Nome = "Alicia", Idade = 18 },
                new Aluno() { Nome = "Sandra", Idade = 19 },
            };
            return alunos;
        }
    }
}
