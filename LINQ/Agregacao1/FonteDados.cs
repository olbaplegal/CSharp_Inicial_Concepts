namespace Agregacao1
{
    class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() {Nome = "Maria", Idade = 36},
                new Aluno() {Nome = "Manuel", Idade = 33},
                new Aluno() {Nome = "Amanda", Idade = 21}
            };
            return alunos;
        }
        
    }
}
