namespace Polimorfismo
{
    class Circulo : Figura //classe derivada
    {
        public override void Desenhar()//sobreescrevendo método desenhar
        {
            Console.WriteLine("Desenhando um Circulo...");//print reescrito
        }
    }
}
