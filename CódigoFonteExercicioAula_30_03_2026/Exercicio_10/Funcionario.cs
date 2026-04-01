using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_10
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public Funcionario(string nome)
        {
            this.nome = nome;
        }
        public abstract double CalcularPagamento();
    }
    public class Vendedor : Funcionario
    {
        public double SalarioBase { get; set; }
        public double Vendas { get; set; }
        public Vendedor(string nome, double salarioBase, double vendas) : base(nome)
        {
            SalarioBase = salarioBase;
            Vendas = vendas;
        }
        public override double CalcularPagamento()
        {
            return SalarioBase + (Vendas * 0.10);
        }
    }
    public class Gerente : Funcionario
    {
        public double SalarioBase { get; set; }
        public double Bonus { get; set; }
        public Gerente(string nome, double salarioBase, double bonus) : base(nome)
        {
            SalarioBase = salarioBase;
            Bonus = bonus;
        }
        public override double CalcularPagamento()
        {
            return SalarioBase + Bonus;
        }
    }
}
