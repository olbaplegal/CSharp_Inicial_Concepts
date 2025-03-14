using PooExercicio2;

LivroFotos livroFotosPadrao = new();//criando instancia
Console.WriteLine($"livroFotosPadrao - Número de páginas: {livroFotosPadrao.GetNumeroPaginas()}");//mostrando número de páginas

//livroFotosPadrao.Nome 
//não dá para acessar o atributo pois ele foi encapsulado

LivroFotos livroFotosNaoPadrao = new(24);
Console.WriteLine($"livroFotosNaoPadrao - Número de páginas: {livroFotosNaoPadrao.GetNumeroPaginas()}");

SuperLivroFotos superLivroFotos = new();
Console.WriteLine($"SuperLivroFotosPadrao - Número de páginas: {superLivroFotos.GetNumeroPaginas()}");
