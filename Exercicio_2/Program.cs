namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe os dados do livro 1");
            Console.Write("Título do livro: ");
            String titulo1 = Console.ReadLine();

            Console.Write("Autor: ");
            String autor1 = Console.ReadLine();

            Console.Write("Ano de publicação:");
            int anoPublicacao1 = int.Parse(Console.ReadLine());

            Console.Write("Gênero: ");
            String genero1 = Console.ReadLine();

            Livro livro1 = new Livro(titulo1, autor1,anoPublicacao1,genero1);

            Console.WriteLine("Informe os dados do livro 2");
            Console.Write("Título do livro: ");
            String titulo2 = Console.ReadLine();

            Console.Write("Autor: ");
            String autor2 = Console.ReadLine();

            Console.Write("Ano de publicação:");
            int anoPublicacao2 = int.Parse(Console.ReadLine());

            Console.Write("Gênero: ");
            String genero2 = Console.ReadLine();

            Livro livro2 = new Livro(titulo2, autor2, anoPublicacao2, genero2);

            Console.WriteLine("------------------------");
            Console.WriteLine($"Livro 1: {livro1.titulo}\nAutor: {livro1.autor}\nAno de Publicação: {livro1.anoPublicacao}\nGênero: {livro1.genero}");

            Console.WriteLine($"Livro 2: {livro2.titulo}\nAutor: {livro2.autor}\nAno de Publicação: {livro2.anoPublicacao}\nGênero: {livro2.genero}");

            Console.WriteLine("------------------------");

            Console.WriteLine("Situação do Livro 1: ");
            if (livro1.emprestado)
            {
                Console.WriteLine("Emprestado");
            }
            else
            {
                Console.WriteLine("Disponível");
            }

            Console.WriteLine("Situação do Livro 2: ");
            if (livro2.emprestado)
            {
                Console.WriteLine("Emprestado");
            }
            else
            {
                Console.WriteLine("Disponível");
            }

            

        }
    }
}
