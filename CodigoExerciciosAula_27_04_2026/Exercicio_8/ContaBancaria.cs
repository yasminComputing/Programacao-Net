using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_8
{
    public  class ContaBancaria
    {
        private decimal saldo = 2500;
      
        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                throw new SaldoInsuficienteException(
                    "Saldo insuficiente para realizar saque");
            }
            
                saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso.\nFicou na conta: R$ {saldo}");
            
        }
    }
}
