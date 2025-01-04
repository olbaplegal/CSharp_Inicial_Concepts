Console.WriteLine("## Operadores de Atribuição ##\n");

//usando operadores de atribuição com tipos númericos
var x = 10;
Console.WriteLine($"O valor inicial de x = {x}");
Console.WriteLine($"x+=5 => {x+=5}");
Console.WriteLine($"x-=5 => {x-=3}");
Console.WriteLine($"x*=5 => {x*=4}");
Console.WriteLine($"x/=5 => {x/=5}");
Console.WriteLine($"x%=5 => {x%=5}");
Console.WriteLine();

var y = "123";
Console.WriteLine($"O valor inicial de y é {y}");
Console.WriteLine($"y+=\"456\" => {y+="456"}");

y = null;
Console.WriteLine($"y+=\"456\" => {y+="456"}");


Console.ReadKey();