using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Aluno : Pessoa
    {
        public Aluno(String nome, int idade) : base(nome, idade)
        {
        }

        public String matricula { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Nome do aluno: {nome} \nIdade: {idade} \nMatrícula: {matricula}");

        }
        public override String ExibirTipo()
        {
            return "\n-------\nSou um aluno ";
        }
    }
}
