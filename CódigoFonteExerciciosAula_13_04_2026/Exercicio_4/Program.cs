namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            String nome;
            double preco;

            while (true)
            {
                Console.WriteLine();
                Console.Write("Qual produto deseja adicionar?\n0 - Finzaliar Programa\n1 - Livro\n2 - Eletrônico\n3 - Roupa\nOpção escolhida? ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0) break;

                if (opcao == 1)
                {
                    Console.Write("Informe o título do Livro: ");
                    nome = Console.ReadLine();
                    Console.Write("Preço: R$ ");
                    preco = double.Parse(Console.ReadLine());
                    Livro livro = new Livro(nome, preco);
                    livro.CalcularDesconto();
                    produtos.Add(livro);
                }
                else if (opcao == 2)
                {
                    Console.Write("Informe o nome do Eletrônico: ");
                    nome = Console.ReadLine();
                    Console.Write("Preço: R$ ");
                    preco = double.Parse(Console.ReadLine());
                    Eletronico eletronico = new Eletronico(nome, preco);
                    eletronico.CalcularDesconto();
                    produtos.Add(eletronico);
                }
                else if (opcao == 3) {
                    Console.Write("Informe o nome da Peça de Roupa: ");
                    nome = Console.ReadLine();
                    Console.Write("Preço: R$ ");
                    preco = double.Parse(Console.ReadLine());
                    Roupa roupa = new Roupa(nome, preco);
                    roupa.CalcularDesconto();
                    produtos.Add(roupa);
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }


            }
            Console.WriteLine("---------------------");
            foreach(Produto prod in produtos)
            {
                prod.ExibirPrecoFinal();
                
            }
        }
    }
}
