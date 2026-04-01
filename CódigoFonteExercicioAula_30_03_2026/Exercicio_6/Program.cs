using System.Data.SqlTypes;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Veiculo> listaVeiculos = new List<Veiculo>();
            String opcao;

            do
            {
                Console.Write("Tipo de veículo (carro/caminhao): ");
                String tipo = Console.ReadLine();
                if (tipo == "carro")
                {
                    listaVeiculos.Add(new Carro());
                }
                else if (tipo == "caminhao")
                {
                    Console.Write("Número de eixos: ");
                    int eixos = int.Parse(Console.ReadLine());
                    listaVeiculos.Add(new Caminhao(eixos));
                }
                Console.WriteLine("Deseja cadastrar outro veículo? (s/n)");
                opcao = Console.ReadLine().ToLower();
            } while (opcao == "s");

            double total = 0;
            foreach(Veiculo veiculo in listaVeiculos) {
                {
                    total += veiculo.CalcularPedagio();
                } 
            }
            Console.WriteLine($"Total: R$ {total}");


        }
    }
}
