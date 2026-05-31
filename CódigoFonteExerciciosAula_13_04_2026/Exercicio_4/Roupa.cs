using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public class Roupa : Produto
    {
      
        public Roupa(String nome,double preco) : base(nome, preco) { }

        public override double CalcularDesconto()
        {
            if (preco > 100)
            {
               preco -= (preco * 0.20);
            }
            else
            {
                preco -= (preco * 0.10);
            }
            return preco;
        }
        public override void ExibirPrecoFinal()
        {
            Console.WriteLine($"Preço final da roupa {nome} é de : R$ {preco}");

        }
    }
}
