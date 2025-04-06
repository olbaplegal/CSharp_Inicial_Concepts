﻿using System.Runtime.Serialization;

namespace ExercoesPersonalizadas
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        { }

        public SaldoInsuficienteException(string? message) : base(message)
        { }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
        { }
        public SaldoInsuficienteException(decimal saque, decimal saldo)
        : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}")
        { }
        public override string Message
        {
            get
            {
                return "Não existe saldo suficiente para o valor so saque";
            }
        }
        public override string? HelpLink
        {
            get
            {
                return "info : https://rb.gv/clgqbv";
            }
        }
    }
}
