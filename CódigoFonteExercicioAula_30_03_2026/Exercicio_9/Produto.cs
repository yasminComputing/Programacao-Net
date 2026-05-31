using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_9
{
    public abstract class Produto
    {
        public double preco { get; set; }

        public Produto(double preco)
        {
            this.preco = preco;
        }
        public abstract double PrecoFinal();
    }
    public class ProdutoNacional : Produto
    {
        public ProdutoNacional(double preco) : base(preco) { }
        public override double PrecoFinal()
        {
            return preco;
        }
        public class ProdutoImportado : Produto
        {
            protected double imposto = 0.20;
            protected double taxa = 10.0;
            public ProdutoImportado(double preco) : base(preco) { }
            public override double PrecoFinal()
            {
                return preco + (preco * imposto) + taxa;
            }
        }
    }
}
