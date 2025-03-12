using InterfaceExercicio;

SalvarXml salvarXml = new();

salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();


Console.ReadKey();