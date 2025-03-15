namespace PooExercicio5
{
    class SQLServer : Database//derivando da classe base
    {
       public override void Conectar()//sobreescrevendo o método virtual
        {
            Console.WriteLine("Conectando ao SQL server...");
        }
        public override void Configurar()//sobreescrevendo o método virtual
        {
            Console.WriteLine("Configurando...");
        }
    }
}
