using PooExercicio10;

//quadrado
Forma forma1 = new Quadrado(3);
Console.WriteLine($"\nResultado = Area = {forma1.Calcular()}");

Forma forma2 = new Triangulo(3, 5);
Console.WriteLine($"\nResultado = Area = {forma2.Calcular()}");

Forma forma3 = new Circulo(8);
Console.WriteLine($"\nResultado = Area = {forma3.Calcular()}");


Console.ReadLine();