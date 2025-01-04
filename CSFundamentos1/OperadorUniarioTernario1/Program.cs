Console.WriteLine($"## Operador Uniário e Ternário ##\n");

//Console.WriteLine("Informe um número: ");
//var n = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine($"O negativo de {n} é {-n}");

//é como um if/else
Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado= temp > 27 ? "Quente" : "normal";
Console.WriteLine($"O tempo está {resultado}");



Console.ReadKey();