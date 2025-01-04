Console.WriteLine("## Operadores Incremento e Decremento ##\n");

//int x = 10;
//x++;
//Console.WriteLine(x);

//x--;
//Console.WriteLine(x);

int x = 0, y = 0, z = 0;
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}\n");
Console.WriteLine($"z = {z}\n");

//pós-incremento -> primeiro resolve depois incrementa.
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento --> {resultado1}");
Console.WriteLine($"valor de x --> {x}\n");

//pre-incremento -> primeiro incrementa, depois resolve.
int resultado2 = ++y + 10;
Console.WriteLine($"pre-incremento --> {resultado2}");
Console.WriteLine($"valor de y --> {y}\n");

//pre-decremento -> primeiro decrementa, depois resolve.
int resultado3 = --z + 10;
Console.WriteLine($"pre-incremento --> {resultado3}");
Console.WriteLine($"valor de z --> {z}\n");

Console.ReadKey();