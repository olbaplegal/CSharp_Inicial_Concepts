using Agregação;

Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Maria", "Inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemática");

Departamento dep1 = new Departamento("Exatas");//criou dep1
dep1.IncluirProfessor(prof1);//adicionando a lista
dep1.IncluirProfessor(prof4);//adicionando a lista
dep1.ListaProfessores();//print
Departamento dep2 = new("Humanas");//criou dep2
dep2.IncluirProfessor(prof2);//adicionando a lista
dep2.IncluirProfessor(prof3);//adicionando a lista
dep2.ListaProfessores();//print

Console.ReadKey();