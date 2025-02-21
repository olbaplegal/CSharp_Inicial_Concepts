Console.WriteLine("## Nullable Types ##\n");

//Nullable<int> i = null;
int? i = null;
double? o = null;
bool? u = null;
Console.WriteLine(i);
Console.WriteLine(o);
Console.WriteLine(u);

//operador de coalescência nula
int? a = null;
int b = a??0;
Console.WriteLine(b);

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

int? c = null;
if (c.HasValue)
{
    Console.WriteLine($"c = {c.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}

Console.ReadKey();
