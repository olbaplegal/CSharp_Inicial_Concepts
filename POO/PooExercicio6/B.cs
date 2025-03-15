namespace PooExercicio6
{
    class B : A //antes de executar qualquer código no construtor de B, o construtor da classe A será chamado, passando "Olá mundo..." como argumento
    //após o codigo do construtor A terminar o código do construtor B continua
    {
        public B(string s) : base(s)
        {
            Console.WriteLine(s);//construtor ta mostrando o S fdp!!! como que eu não tinha visto isso?
        }
    }
}
