using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public abstract class Pessoa
    {
        public String nome { get; set; }
        public int idade { get; set; }

        public Pessoa(String nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public abstract void Apresentar();

        public virtual String ExibirTipo()
        {
            return "Não sou aluno e nem professor.";
        }
    }
}


