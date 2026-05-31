using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    public abstract class Animal 
    {
        public String nome{get; set;}
        public Animal(String nome)
        {
            this.nome = nome;
        } 
        public abstract void EmitirSom();
      
        }
     public class Cachorro: Animal
    {
        public Cachorro(String nome) : base(nome)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine($"{nome}: Au au!");
        }
    }
    public class Gato: Animal
    {
        public Gato(String nome) : base(nome)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine($"{nome}: Miau miau!");
        }
    }
}

