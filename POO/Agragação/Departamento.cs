namespace Agregação
{
    internal class Departamento//criando classe Departamento(internal pois está no mesmo assemble)
    {
        public Departamento(string? nome)//construct com parametro string
        {
            Nome = nome;//Atributo Nome recebe o valor do parametro nome
            professores = new List<Professor>();//
        }

        public string? Nome { get; set; }//propriedade string Nome 
        public List<Professor> professores { get; set; }//propriedade lista do tipo Professor chamada professores 
        public void IncluirProfessor(Professor professor)//método para adicionar professores a lista
        {
            professores?.Add(professor);//'?' => elvis => se o valor de professor for null, irá retornar null e não proseguira com o codigo
        }
        public void ListaProfessores()//método para mostrar professores da lista
        {
            Console.WriteLine($"\nDepartamento de: {Nome}\n");//print

            foreach (var prof in professores)//foreach na lista
                Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);//print de nomes e disciplinas
        }
    }
}
