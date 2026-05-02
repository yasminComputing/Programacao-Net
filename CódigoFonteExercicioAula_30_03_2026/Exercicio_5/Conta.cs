using System;

namespace Exercicio_5
{
    public abstract class Conta
    {
        protected double saldo { get; set; }

        public Conta(double saldoInicial)
        {
            saldo = saldoInicial;
        }

        public abstract double Sacar(double valor);

        public double ConsultarSaldo()
        {
            return saldo;
        }
    }

   
    public class ContaCorrente : Conta
    {
        public ContaCorrente(double saldoInicial) : base(saldoInicial) { }

        public override double Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado. Saldo atual: R$ {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }
            return saldo;
        }
    }


    public class ContaPoupanca : Conta
    {
        private double taxaSaque = 0.50;

        public ContaPoupanca(double saldoInicial) : base(saldoInicial) { }

        public override double Sacar(double valor)
        {
            double valorTotal = valor + taxaSaque;

            if (valorTotal <= saldo)
            {
                saldo -= valorTotal;
                Console.WriteLine($"Saque de R$ {valor} realizado com taxa de {taxaSaque}. Saldo atual: {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }

            return saldo;
        }
    }

}