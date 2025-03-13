using Acoplamento;

ComportamentoAndar andar = new();//criando instancia da classe ComportamentoAndar
ComportamentoNadar nadar = new();//criando instancia da classe ComportamentoNadar

var homem = new Homem(andar);//criando instancia da classe Homem com parametro andar para receber este parametro no construtor
homem.Locomocao();//locomoção

var macaco = new Macaco(andar);//criando instancia da classe Macaco com parametro andar para receber este parametro no construtor
macaco.Locomocao();//locomoção

var sardinha = new Sardinha(nadar);//criando instancia da classe Sardinhacom parametro andar para receber este parametro no construtor
sardinha.Locomocao();//locomoção

Console.ReadKey();