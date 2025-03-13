using PooExercicio1;

Carro carro = new Carro(0);//criando instancia com gasolina 0

Console.WriteLine("Informe quantos litros de gasolina: ");//print

int gasolina = Convert.ToInt32(Console.ReadLine());//quantidade de gasolina

if (carro.Abastecer(gasolina)) //se true, então 
{
    carro.Dirigir();//método de dirigir que só será acionado se o resultado for true
}