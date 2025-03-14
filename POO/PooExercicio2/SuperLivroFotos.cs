namespace PooExercicio2
{
    class SuperLivroFotos
    {
        public SuperLivroFotos()
        {
            NumPaginas = 64;
        }
        public SuperLivroFotos(int numPaginas)
        {
            NumPaginas = numPaginas;
        }

        private int NumPaginas = 64;

        public int GetNumeroPaginas()
        {
            return NumPaginas;
        }
    }
}
//mesma coisa da classe LivroFotos.cs