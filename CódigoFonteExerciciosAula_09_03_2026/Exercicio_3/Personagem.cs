using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    internal class Personagem
    {
        public String nome;
        public String posicao;
        public String itemColetados;

public Personagem(String nome, String posicao, String itemColetados)
        {
            this.nome = nome;
            this.posicao = posicao;
            this.itemColetados = itemColetados;
        }
public void Atacar(double dano)
        {
            Console.WriteLine($"O personagem {nome} atacou causando {dano} de dano.");
        }

public void Movimentar(int direcao)
        {
            if (direcao == 1)
            {
                Console.WriteLine($"{nome} se moveu para frente");
            }
            else if (direcao == 2)
            {
                Console.WriteLine($"{nome} se moveu para trás");
            }
            else if (direcao == 3)
            {
                Console.WriteLine($"{nome} se moveu para a direita");
            }
            else if (direcao == 4)
            {
                Console.WriteLine($"{nome} se moveu para a esquerda");
            }
            else
            {
                Console.WriteLine("Direção inválida!");
            }



        }
    }
}
