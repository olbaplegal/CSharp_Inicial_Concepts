namespace _10Indexadores
{
    internal class Time
    {
        //definir os limite do array
        string[] valor = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < valor.Length)
                {
                    return valor[i];
                }
                return "Erro";
            }
            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    //atribui o valor
                    valor[i] = value;
                }
            }
        }
    }
}
