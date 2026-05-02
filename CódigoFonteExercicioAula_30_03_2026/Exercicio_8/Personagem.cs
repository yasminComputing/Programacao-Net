using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_8
{
    public abstract class Personagem
    {
        public string nome { get; set; }

        public Personagem(string nome)
        {
            this.nome = nome;
        }
        public abstract void Atacar();
    }
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base(nome) { }
        public override void Atacar()
        {
            Console.WriteLine($"{nome} atacou com espada!");
        }
    }
    public class Mago : Personagem
    {
        public Mago(string nome) : base(nome) { }

        public override void Atacar()
        {
            Console.WriteLine($"{nome} atacou com magia!");
        }
    }
}
