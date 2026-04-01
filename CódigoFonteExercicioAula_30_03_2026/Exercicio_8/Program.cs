namespace Exercicio_8
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            List<Personagem> personagens = new List<Personagem>();
            int quantidade;
            Console.WriteLine("Quantos personagens deseja cadastrar?");
            quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"\nDigite o nome do personagem {i + 1}:");
                String nome = Console.ReadLine();

                String tipo;
                do
                {
                    Console.WriteLine("Escolha o tipo do personagem (guerreiro/mago):");
                    tipo = Console.ReadLine().ToLower();
                } while (tipo != "guerreiro" && tipo != "mago");

                if (tipo == "guerreiro")
                    personagens.Add(new Guerreiro(nome));
                else
                    personagens.Add(new Mago(nome));
            }

            // Simular 3 turnos
            Console.WriteLine("\n--- Início da Batalha ---");
            for (int turno = 1; turno <= 3; turno++)
            {
                Console.WriteLine($"\nTurno {turno}:");
                foreach (Personagem p in personagens)
                {
                    p.Atacar();
                }
            }
        }
    }
}