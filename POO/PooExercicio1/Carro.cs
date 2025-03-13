namespace PooExercicio1
{
    class Carro : IVeiculo//implementando classe com a interface
    {
        public int Gasolina { get; set; }//propriedade gasolina
        public Carro(int gasolina)//método construtor com parametro int gasolina
        {
            Gasolina = gasolina;//propriedade vai recever método
        }
        public void Dirigir()//método de dirigir
        {
            if (Gasolina > 0)//se gasolina for > 0
            {
                Console.WriteLine("Dirigindo o carro...");//print
            }
            else//senao
            {
                Console.WriteLine("Sem Gasolina...");//print
            }
        }
        public bool Abastecer(int quantidade)//método para abastecer
        {
            Gasolina += quantidade;//abastecendo
            return true;//retorno
        }
    }
}
