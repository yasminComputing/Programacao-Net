using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Professor : Pessoa
    {
        public Professor(String nome, int idade) : base(nome, idade)
        {

        }
        public String disciplina { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Nome do professor: {nome} \nIdade: {idade} \nDisciplina: {disciplina}");
        }
        public override String ExibirTipo()
        {
            return "\n----\nSou um professor";
        }
    }
}
