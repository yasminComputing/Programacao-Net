using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public abstract class ContaBancaria
    {
        protected double saldo;
        public ContaBancaria(double saldo)
        {
            this.saldo = saldo;
        }
        public abstract double Depositar(double valorDeposito);

        public abstract double Sacar(double valorSaque);

        public virtual  void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual na conta: R$ {saldo}");
        }
    }
}
