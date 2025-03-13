namespace Acoplamento
{
    class Homem : Animal
    {
        //composição de macaco com o comportamento andar
        private readonly ComportamentoAndar _comportamentoAndar;//propriedade privada e somente leitura para não poder ser alterada após receber a instância no construtor


        public Homem(ComportamentoAndar comportamentoAndar)//construtor para fazer a propriedade receber o valor do tipo comportamento andar
        {
            _comportamentoAndar = comportamentoAndar;//recebendo valor
        }

        public void Locomocao()//método para andar
        {
            //nameof produz o nome de uma variavel, tipo ou membro como constante de cadeia de caracteres
            Console.WriteLine(nameof(Homem));//printando a classe
            _comportamentoAndar.Andar();//ultilizando um obj da classe ComportamentoAndar para usar o método Andar 
        }
    }
}
