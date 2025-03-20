Console.WriteLine("## Constantes ##\n");

double raio, perimetro, area;
const double PI = 3.1415926535;

Console.WriteLine("Informe o raio do circulo: ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"Perímetro: {perimetro}");
Console.WriteLine($"Área: {area}");

Console.ReadKey();

//const int ANO = 12;

//const int MES = 30, SEMANA = 7, QUINZENA = 15;

//const int MES_ANO = 12;
//const int DIAS_ANO = 365;

//const float DIAS_POR_MES = (float) DIAS_ANO / MES_ANO;
//Console.WriteLine(DIAS_POR_MES);