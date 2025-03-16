namespace PooExercicio10
{
    class Triangulo : Forma
    {
        public Triangulo(double Base, double altura)
        {
            this.Base = Base;
            Altura = altura;
        }
        private double Base { get; set; }
        private double Altura { get; set; }
        public override double Calcular()
        {
            Area = (Base * Altura) / 2;
            return Area;
        }
    }
}
