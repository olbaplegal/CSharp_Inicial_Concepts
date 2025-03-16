using PooExericico9;

MastroCreditCard cartao = new();
cartao.ValidarCartao();
cartao.IniciarTransacao();
cartao.StatusTransacao();

//A classe MastroCreditCard precisa implementar a validação d ocartão e a inicialização que devem ser definidos em classes ou interfaces diferentes, e com isso vai precisar herdar das duas classes ou interfaces.
//como não podemos herdar de duas classes a solução é criar duas interaces ( ou uma classe e  uma interface ) e fazer com que a classe MastroCreditCard herde das duas interfaces ( ou herde da classe e implemente a interface )