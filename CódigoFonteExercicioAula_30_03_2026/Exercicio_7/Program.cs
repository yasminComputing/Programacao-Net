namespace Exercicio_7
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                List<ItemBiblioteca> itens = new List<ItemBiblioteca>();

            Console.WriteLine("Qual deseja cadastrar (livro/revista): ");
            String opcao = Console.ReadLine().ToLower();

            Console.WriteLine("Título: ");
            String titulo = Console.ReadLine();

            Console.WriteLine("Autor: ");
            String autor = Console.ReadLine();

            if (opcao == "livro") {
                itens.Add(new Livro(titulo, autor));     
            }
            else if (opcao == "revista")
            {
                Console.WriteLine("Edição: ");
                String edicao  = Console.ReadLine();
                itens.Add(new Revista(titulo, autor,edicao));
            }
            else
            {
                Console.WriteLine("Opção informada inválida!");
            }

                foreach (ItemBiblioteca item in itens)
                {
                    item.ExibirDestaque();
                }
            }
        };
        
    }

