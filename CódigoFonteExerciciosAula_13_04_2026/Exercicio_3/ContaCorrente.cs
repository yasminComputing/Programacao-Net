using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public  class ContaCorrente : ContaBancaria
    {

        private double taxaSaque = 2.00;
        public ContaCorrente(double saldo) : base(saldo) { }

        public override double Depositar(double valorDeposito)
        {
           if (valorDeposito > 0)
            {
                saldo += valorDeposito;
            }
            else
            {
                Console.WriteLine("Não é possível completar o depósito!");
            }
            return saldo;
        }
        public override double Sacar(double valorSaque)
        {
            return saldo -= (valorSaque +taxaSaque);
        }

        public override void ExibirSaldo()
        {
            Console.WriteLine($"Saldo na conta corrente: R$ {saldo}");
        }     
        
    }
}
