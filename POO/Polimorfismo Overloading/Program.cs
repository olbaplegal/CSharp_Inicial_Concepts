//overloaading => polimorfismo por meio da sobrecarga de métodos
//dois métodos com o mesmo nome
//com base nos parametros a execução é decidida em tempo de compilação
Calcular calc = new Calcular();
Console.WriteLine(calc.Somar(30,40));
Console.WriteLine(calc.Somar(30,40, 50));



Console.ReadKey();

class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}

