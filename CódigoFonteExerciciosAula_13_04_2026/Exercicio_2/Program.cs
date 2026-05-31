namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculo = new List<Veiculo>();

            String marca, modelo;

            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("0 - Finalizar");
                Console.WriteLine("1 - Adicionar carro");
                Console.WriteLine("2 - Adicionar moto");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");

                if (opcao == 0) break;

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe os dados da CARRO");
                        Console.Write("Marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        modelo = Console.ReadLine();
                        Carro carro = new Carro(marca, modelo);
                        Console.Write("KM rodados: ");
                        carro.km = double.Parse(Console.ReadLine());
                        Console.Write("Litro gasto: ");
                        carro.litros = double.Parse(Console.ReadLine());

                        veiculo.Add(carro);
                        break;

                    case 2:
                        Console.WriteLine("Informe os dados da MOTO");
                        Console.Write("Marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        modelo = Console.ReadLine();
                        Moto moto = new Moto(marca, modelo);
                        Console.Write("Qual cilindrada da moto? ");
                        moto.cilindrada = int.Parse(Console.ReadLine());

                        veiculo.Add(moto);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }

            }
               foreach(Veiculo veic in veiculo)
                {
                    veic.Dirigir();
                    Console.WriteLine($"Consumo: {veic.CalcularConsumo()}");
                    
                }
        }
    }
}
