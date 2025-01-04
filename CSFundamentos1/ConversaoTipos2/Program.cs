Console.WriteLine("## Convesão de tipos 2 ##\n");

int valorInt = 123;
double valorDouble = 12.43;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine();

valorInt = 10;
valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

int varInt = 100000;
Console.WriteLine(Convert.ToByte(varInt));


Console.ReadKey();