using HerancaExercicioV2;

Console.WriteLine("\nConta Corrente : Numero: 111 Titular: Maria");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";
Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}"); // ToString("c")} bota em real
Console.WriteLine("Sacando R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}");
Console.ReadKey();

Console.WriteLine("\nConta Poupança : Numero: 222 Titular: José");
ContaPoupanca contapoupanca = new();
contapoupanca.Numero = 222;
contapoupanca.Titular = "José";
Console.WriteLine("Depositando R$ 1.000,00");
contapoupanca.Depositar(1000);
Console.WriteLine($"Saldo da ContaPoupaca : {contapoupanca.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 100.00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da ContaPoupaca : {contapoupanca.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
contapoupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta Poupança: {contapoupanca.Saldo.ToString("c")}");
Console.ReadKey();

Console.WriteLine("\nConta Investimento : Numero: 333 Titular: Ana");
ContaInvestimento containvestimento = new();
containvestimento.Numero = 333;
containvestimento.Titular = "Ana";
Console.WriteLine("Depositando R$ 1.000,00");
containvestimento.Depositar(1000);
Console.WriteLine($"Saldo da Conta Investimento : {containvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 200,00");
containvestimento.Sacar(200);
Console.WriteLine($"Saldo da Conta Investimento : {containvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
containvestimento.Sacar(2000);
Console.WriteLine($"Saldo da Conta Investimento : {containvestimento.Saldo.ToString("c")}");
Console.ReadKey();