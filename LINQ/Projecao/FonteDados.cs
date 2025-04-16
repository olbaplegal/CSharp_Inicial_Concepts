namespace Projecao
{
    class FonteDados
    {
        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 512
            };
            return numeros;
        }
        public static List<int> GetListaNegra()
        {
            List<int> numeros = new List<int>()
            {
                16, 138, 512
            };
            return numeros;
        }
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome = "Maria", Idade = 42, Nota = 7,},
                new Aluno() { Nome = "Manoel", Idade = 34, Nota = 6,},
                new Aluno() { Nome = "Amanda", Idade = 21, Nota = 5,},
                new Aluno() { Nome = "Carlos", Idade = 18, Nota = 9,},
                new Aluno() { Nome = "Alicia", Idade = 15, Nota = 4,},
            };
            return alunos;
        }
    }
}
