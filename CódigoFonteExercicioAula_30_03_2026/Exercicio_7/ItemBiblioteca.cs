using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_7
{
    public abstract class ItemBiblioteca
    {
        public string titulo { get; set; }
        public string autor { get; set; }

        public ItemBiblioteca(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public abstract void ExibirDestaque();
    }
    public class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string autor) : base(titulo, autor) { }

        public override void ExibirDestaque()
        {
            Console.WriteLine($"LIVRO: {titulo.ToUpper()} - Autor: {autor}");
        }
    }
    public class Revista : ItemBiblioteca
    {
        public string Edicao { get; set; }

        public Revista(string titulo, string autor, string edicao) : base(titulo, autor)
        {
            Edicao = edicao;
        }

        public override void ExibirDestaque()
        {
            Console.WriteLine($"REVISTA: {titulo} - Edição: {Edicao} - Autor: {autor}");
        }
    }
}
