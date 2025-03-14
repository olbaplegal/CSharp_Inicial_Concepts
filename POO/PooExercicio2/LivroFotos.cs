namespace PooExercicio2
{
    class LivroFotos//classe livros
    {
        public LivroFotos()//construtor sem paramentros
        {
            NumPaginas = 16;
        }
        public LivroFotos(int numPaginas)//construtor com recebimento de parametros
        {
            NumPaginas = numPaginas;//atributo NumPaginas recebe valor do parametro 
        }
        private int NumPaginas;//atributo privador(emcapsulado)

        public int GetNumeroPaginas()//método para retornar o número de paginas
        {
            return NumPaginas;//números de páginas
        }
    }
}
