Console.WriteLine("## Construtor Estático ##\n");

//invoca o construtor parametrizado e o estatico
Pessoa p1 = new(19, "maria");
Console.WriteLine($"{p1.Nome} - {p1.Idade}");
Console.WriteLine($"idade minima {Pessoa.IdadeMinima}");

//vai invocar somente o construct parametrizado
Pessoa p2 = new(20, "manuel");
Console.WriteLine($"{p2.Nome} - {p2.Idade}");
Console.WriteLine($"idade minima {Pessoa.IdadeMinima}");


Console.ReadKey();
