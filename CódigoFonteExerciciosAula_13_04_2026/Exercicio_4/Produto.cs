using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public abstract class Produto
    {
        public String nome { get; set; }
        public double preco { get; set; }

        public Produto(String nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public abstract double CalcularDesconto();
        public abstract void ExibirPrecoFinal();
    }
   }

