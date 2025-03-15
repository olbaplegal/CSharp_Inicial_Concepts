namespace PooExercicio4
{
    class Pessoa
    {
        public string Nome { get; set; }//atributo nome
        public override string ToString()//modificando método ToString
        {
            return "Olá! Meu nome é " + Nome;
        }
    }
}
