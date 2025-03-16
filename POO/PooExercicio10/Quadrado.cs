namespace PooExercicio10
{
    class Quadrado : Forma
    {
        private double Lado { get; set; }
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double Calcular()
        {
            Area = Lado * Lado;
            return Area;
        }
    }
}
