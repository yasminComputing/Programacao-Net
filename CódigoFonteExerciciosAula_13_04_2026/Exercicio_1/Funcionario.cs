using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string nome, int idade) : base(nome, idade)
        {
        }
        public String cargo { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nCargo:{cargo}");
        }
        public override String ExibirTipo()
        {
            return "\n-------\nSou um funcionário ";
        }
    }
}
