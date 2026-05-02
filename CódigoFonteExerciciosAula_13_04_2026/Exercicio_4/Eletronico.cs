using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public class Eletronico : Produto
    {
        private double descontoEletronico = 0.125;
        public Eletronico(String nome,double preco) : base(nome, preco) { }

        public override double CalcularDesconto()
        {
            return preco -= (preco * descontoEletronico);
        }
        public override void ExibirPrecoFinal()
        {
            Console.WriteLine($"Preço final do eletrônico {nome} é de : R$ {preco}");

        }
    }
}
