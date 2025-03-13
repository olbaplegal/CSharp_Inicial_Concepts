namespace Acoplamento
{
    class Sardinha : Animal//herdando comportamentos
    {
        private readonly ComportamentoNadar _comportamentoNadar;//declarando _comportamentoNadar

        public Sardinha(ComportamentoNadar comportamentoNadar)//contrutor
        {
            _comportamentoNadar = comportamentoNadar;//_comportamentoNadar recebe valor da instancia criada no program
        }

        public void Locomocao()//método de locomoção
        {
            Console.WriteLine(nameof(Sardinha));//printando nome do animal(nome da classe)
            _comportamentoNadar.Nadar();//ultilizando método para printar locomoção
        }
    }
}
