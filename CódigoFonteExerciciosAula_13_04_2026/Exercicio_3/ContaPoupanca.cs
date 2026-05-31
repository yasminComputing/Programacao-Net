using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca (double saldo) : base(saldo) { }

        public override double Depositar(double valorDeposito)
        {
            if(valorDeposito > 0)
            {
                saldo += valorDeposito;
            }
            return saldo;
        }
        public override double Sacar(double valorSaque)
        {
            if(valorSaque > saldo && valorSaque > 0)
            {
                Console.WriteLine("Não é possível completar o saque!Valor maior que o saldo!");
            }
            else
            {
                saldo -= valorSaque;
            }
            return saldo;
        }
        public override void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual na conta poupança: R$ {saldo}");
        }
    }
}
