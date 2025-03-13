namespace Agregação
{
    class Professor//inicio da classe
    {
        public string? Nome { get; set; }//propriedade Nome
        public string? Disciplina { get; set; }//propriedade Disciplina
        public Professor(string? nome, string? disciplina)//construct professor
        {
            Nome = nome;//nome
            Disciplina = disciplina;//disciplina
        }
    }
}
