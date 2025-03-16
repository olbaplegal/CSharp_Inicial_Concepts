namespace PooExercicio10
{
    class Circulo : Forma
    {
        public Circulo(double raio)
        {
            Raio = raio;
        }
        private double PI { get; set; } = Math.PI;
        private double Raio { get; set; }
        public override double Calcular()
        {
            Area = PI * (Raio*Raio);
            return Area;
        }
    }
}
