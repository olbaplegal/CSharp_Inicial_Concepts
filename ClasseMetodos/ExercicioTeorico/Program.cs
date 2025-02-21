//1- O que é uma classe e qual a sua composição ? R:Uma classe é um modelo para criar objetos (uma estrutura de dados específica), fornecer valores iniciais para estado (variáveis ou atrivuros de membro) e implementações de comportamento (funções ou métodos de membro)
//2- O que é um objeto e como pode ser criado ? R: O objeto é uma instância da classe que pode ser usado para acessar métodos de classe. A palavra-have "New" pode ser usada para construir um objeto
//3 - Qual a diferença entre classe e objeto ? R: A classe é o modelo que descreve os objetos e suas características e comportamentos. Um objeto é o modelo personalizado com valores e estado que podem ser categorizados e agrupado. O objeto materializa a classe
//4- O que é um método e como pode ser criado e chamado ? R: Um método é um bloco de código que contém uma série de instruções. Um programa executa as instruções chamando o método e especificando argumentos. Para chamar m método temos que criar uma instância da classe
//5- O que é um parâmetro de método ? R: Um parâmetro é um valor, proveniente de uma variável ou de uma expressão mais complexa que representa um valor que o método espera recever quando for chamado. Um parâmetro possui um nome.
//6- O que é um argumento ? R: Um argumento representa o valor que você passa para um parâmetro de método quando você chama o método. O código de chamada fornece os argumentos quando chama o métodol. Um argumento não tem nome.
//7- O que é um construtor e qual o seu objetivo ? R: Um construtor é um método especial com o mesmo nome de sua classe. O construtor é invocado automaticamente quando um objeto é criado. Enquanto a classe está sendo inicializada, ela constrói todos os valores do membros de dados
//8- Quais os usos da palavra chave this ? R: A palavra chave this refere-se à instância atual da classe e pode ser usada também para passar um objeto da instância atual para outros métodos, invocar outro construtor da mesma classe ou da classe base
//9- O que é um método com retorno ? R: uma instrução que encerra a execução de uma função e retorna o controle para a função de chamada
//10- O que é sobrecarga de método ? R: é quando há a criação de mais de um procedimento, construtor de instância ou propriedade em uma classe com o mesmo nome, mas tipos de argumentos diferentes
//11- Como é feita a passagem de parâmetros por valor ? R: int x = 1
//12- Como é feita a passagem de parâmetros por referência ?string y = "1"
//13- Qual a diferença entre os parâmetros out e o parâmetro ref ? ref: o argumento deve ser inicializado antes de chamar o método. O método pode atribuir um novo valor ao parâmetro, mas não é necessário fazer isso. out: o método de chamada não é necessário para inicializar o argumento antes de chamar o método. O método deve atribuir um valor ao parâmetro
//14- O que são argumentos nomeados ? Os argumentos nomeados leberam você da necessidade de combinar a ordem dos argumentos com a ordem dos parâmetros nas listas de parâmetros de métodos chamados
//15- O que são parâmetros opcionais ? Os argumentos nomeados permitem que você especifique um argumento para um parâmetro correspodendo o argumento com seu nome em vez de com sua posição na lista de parâmetros
//16- Qual o efeito da palavra-chave static ? indica que um membro pertence ao tipo, e não a uma instância do tipo
//17 - O que é método estático e qual o seu comportamento ? Um método estático indica que na verdade não sabe a qum pertence, como ele não é um método de instância, ele não precisa da instância da classe para ser usado.
//18- O que é um campo estático e qual o seu comportamento ? É um campo que pertence ao tipo, não a um objeto específico
//19- O que são propriedades ? Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou clacular o valor de um campo de dados
//20- Qual a diferença entre campos e propriedades ? Os campos armazenam dados, enquanto as propriedades são métodos que acessam os campos
//21- O que é uma struct ? é uma classe que contem seus valores na memória stack
//22- Qual a diferença entre uma struct e uma classe ? struct mantem seus valore na memória stack, a class não
//23- O que é uma Enum ? É um tipo de valor definido por um conjunto de constantes nomeadas do tipo número integral
//24- Quais são e qual o escopo dos modificadores de acesso ? public, protected, internal, private
//25- Qual a regra geral para usar os modificadores de acesso ? 