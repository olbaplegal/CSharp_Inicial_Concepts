using System.Collections.Generic;

namespace DictionaryExercicio
{
    class Aluno
    {
        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;

        }
        public string? Nome { get; set; }
        public int Nota { get; set; }
        public static void ExibirColecao(Dictionary<int, Aluno> alunos)
        {
            Console.WriteLine("\nKey - Nomes - Notas");
            foreach (var item in alunos)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} - {item.Value.Nota}");
            }
        }
    }

}
