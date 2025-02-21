Console.WriteLine("## Operadores Aritméricos ##\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

//outras operações ultizando a classe Math
Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"potencia de x = {Math.Pow(x,y)}");
Console.WriteLine($"valor minimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"valor maximo entre x e y = {Math.Max(x,y)}");
Console.WriteLine($"Coseno x = {Math.Cos(x)}");
Console.WriteLine($"Seno x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");



Console.ReadKey();

//Console.WriteLine($"soma de x+y = {x+y}");
//Console.WriteLine($"subtração de x-y = {x-y}");
//Console.WriteLine($"multiplicação de x*y = {x*y}");
//double divisao = (double) x / y;
//Console.WriteLine($"divisão de x/y = {divisao}");
//Console.WriteLine($"modulo de x%y = {x%y}");