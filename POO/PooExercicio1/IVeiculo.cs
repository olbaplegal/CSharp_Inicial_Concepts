namespace PooExercicio1
{
    interface IVeiculo//criando interface
    {
        void Dirigir();//declarando método retorno void
        bool Abastecer(int quantidade);//declarando método retorno bool
    }
}
//para a interface ser totalmente implementada na classe, todos os métodos precisam ser sobreescritos
