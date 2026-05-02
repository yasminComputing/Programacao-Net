using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    internal class Livro
    {
        public String titulo;
        public String autor;
        public int anoPublicacao;
        public String genero;
        public bool emprestado;


public Livro(String titulo, String autor,int anoPublicacao,String genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.genero = genero;
            this.emprestado = false;
        }
public void Emprestar()
        {
            emprestado = true;
           
        }
public void Devolver()
        {
            emprestado = false;
        }
    }
}
