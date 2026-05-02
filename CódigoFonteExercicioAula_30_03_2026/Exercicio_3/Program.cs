namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Escolha a forma:");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Retângulo");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite o lado do quadrado: ");
                float lado = float.Parse(Console.ReadLine());

                Quadrado q = new Quadrado(lado);
                Console.WriteLine("Área do quadrado: " + q.CalcularArea());
            }
            else if (opcao == 2)
            {
                Console.Write("Digite a base do retângulo: ");
                float b = float.Parse(Console.ReadLine());

                Console.Write("Digite a altura do retângulo: ");
                float h = float.Parse(Console.ReadLine());

                Retangulo r = new Retangulo(b, h);
                Console.WriteLine("Área do retângulo: " + r.CalcularArea());
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
    }
}
