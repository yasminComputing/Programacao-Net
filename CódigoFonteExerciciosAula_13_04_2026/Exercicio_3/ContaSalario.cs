using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public class ContaSalario : ContaBancaria
    {
        public ContaSalario(double saldo): base(saldo) { }

        public override double Depositar(double valorDeposito)
        {
            Console.WriteLine("Não é permitido depositar!");
            return saldo; 
        }
        public override double Sacar(double valorSaque)
        {
            if(valorSaque > 0 &&  valorSaque <= saldo)
            {
                saldo -= valorSaque;
            }
            else
            {
                Console.WriteLine("Não é possível completar o saque!Valor maior que o saldo!");
            }
            return saldo;
        }
        public override void ExibirSaldo()
        {
            base.ExibirSaldo();
        }
    }
}
