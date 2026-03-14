using System.Security.Cryptography.X509Certificates;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do personagem");

            Console.Write("Nome:");
            String nome = Console.ReadLine();

            Console.Write("Posição: ");
            String posicao = Console.ReadLine();

            Console.Write("Itens coletados: ");
            String itemColetado = Console.ReadLine();

            Personagem personagem= new Personagem(nome, posicao, itemColetado);

            Console.Write("Informe dano do ataque (0 a 10):");
            double dano = double.Parse(Console.ReadLine());
            if (dano < 0 || dano > 10)
            {
                Console.WriteLine("Valor de dano inválido!Tente Novamente");
                return;
            }

            personagem.Atacar(dano);

            Console.Write("Informe a direção\n1- Frente\n2- Trás\n3- Direita\n4- Esquerda\nQual opção escolhida?  ");
            int direcao = int.Parse(Console.ReadLine());
            if(direcao < 1 || direcao > 4)
            {
                Console.WriteLine("Direção inválido!Tente Novamente");
                return;
            }
            personagem.Movimentar(direcao);

        }
    }
}
