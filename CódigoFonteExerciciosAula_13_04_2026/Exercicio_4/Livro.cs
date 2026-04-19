using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public class Livro : Produto
    {
        private double descontoLivro = 0.05;
        public Livro(String nome,double preco) : base(nome, preco) { }

        public override double CalcularDesconto()
        {
            return preco -=(preco * descontoLivro);
        }
        public override void ExibirPrecoFinal()
        {
            Console.WriteLine($"Preço final do livro {nome} é de : R$ {preco}");
        }
    }
}
