using static Exercicio_9.ProdutoNacional;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
            {
               Carrinho carrinho = new Carrinho();
                String opcao;

            do
            {
                Console.WriteLine("Digite o tipo de produto (nacional/importado):");
                String tipo = Console.ReadLine().ToLower();

                Console.WriteLine("Informe o preço do produto:");
                double preco = double.Parse(Console.ReadLine());

                if (tipo == "nacional")
                {
                    carrinho.Produto.Add(new ProdutoNacional(preco));
                }

                else if (tipo == "importado")
                {
                    carrinho.Produto.Add(new ProdutoImportado(preco));
                }

                else
                {
                    Console.WriteLine("Tipo inválido!");
                }
                Console.WriteLine("Adicionar outro produto (s/n): ");
                opcao = Console.ReadLine();
            } while (opcao == "s");
            

                Console.WriteLine($"\nTotal do carrinho: R$ {carrinho.Total():F2}");
            }
        }
    }
    

