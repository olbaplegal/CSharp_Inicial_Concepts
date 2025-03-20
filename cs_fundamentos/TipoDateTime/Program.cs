Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;

//criar uma data especifica usa formato : aaaa, mm, dd
DateTime dataHoje = new DateTime(2022, 09, 06);
Console.WriteLine(dataHoje);

//definir horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);

//extrair informações da data atual
Console.WriteLine($"\nhoje : {dataAtual}\n");
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

//adicionando valores
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));

//obter o dia da semana e do ano
Console.WriteLine(dataHoje.DayOfWeek);
Console.WriteLine(dataHoje.DayOfYear);

//data no formato longo e curto
Console.WriteLine(dataHoje.ToLongDateString());
Console.WriteLine(dataHoje.ToShortDateString());

Console.WriteLine(dataHoje.ToLongTimeString);
Console.WriteLine(dataHoje.ToShortTimeString);


Console.ReadKey();