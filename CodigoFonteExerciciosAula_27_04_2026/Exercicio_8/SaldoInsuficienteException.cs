using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_8
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException (String mensagem) : base(mensagem)
        {

        }
    }
}
