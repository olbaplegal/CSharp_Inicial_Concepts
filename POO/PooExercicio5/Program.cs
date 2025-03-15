using PooExercicio5;

Database db = new SQLServer();//criando objeto SQLServer, mas referenciando como Database. isso permite que métodos definidos na classe Database sejam chamados, mas com a possibilidade de serem sobrescritos pela classe SQLServer.
db.Configurar();//chamando método configurar(), que é abstrato na classe Database, mas obrigatoriamente implementado na classe SQLServer
db.Conectar();//método sobreescrito na classe derivada

Console.ReadKey();