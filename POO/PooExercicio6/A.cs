namespace PooExercicio6
{
    class A
    {
        string Texto;//atriuto texto

        public A(string s)//construtor A com parametro s
        {
            this.Texto = s;//atributo texto recebe parametro s
        }
        public void Exibir()
        {
            Console.WriteLine(Texto);
        }
    }
}
