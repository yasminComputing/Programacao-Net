using System.ComponentModel;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();

            double valorDeposito, valorSaque,saldo;
            while (true)
            {
                Console.WriteLine("Qual seu tipo de conta? ");
                Console.Write("1 - Corrente\n2 - Poupança\n3 - Salário\nOpção? ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.Write("\nSaldo inicial da conta: R$ ");
                        saldo = int.Parse(Console.ReadLine());

                        Console.Write("Menu\n1 - Depositar\n2 - Saque\nOpção? ");
                        int escolha = int.Parse(Console.ReadLine());

                        ContaCorrente corrente = new ContaCorrente(saldo);
                        if (escolha == 1)
                        {
                            Console.Write("Qual valor que deseja depositar? R$ ");
                            valorDeposito = int.Parse(Console.ReadLine());
                            corrente.Depositar(valorDeposito);
                        }
                        else if (escolha == 2)
                        {
                            Console.Write("Qual valor que deseja sacar? R$ ");
                            valorSaque = int.Parse(Console.ReadLine());

                            corrente.Sacar(valorSaque);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }

                        contas.Add(corrente);

                        break;
                    case 2:
                        Console.Write("\nSaldo inicial da conta: R$ ");
                        saldo = int.Parse(Console.ReadLine());

                        Console.Write("Menu\n1 - Depositar\n2 - Saque\nOpção? ");
                        escolha = int.Parse(Console.ReadLine());

                        ContaPoupanca poupanca = new ContaPoupanca(saldo);
                        if (escolha == 1)
                        {
                            Console.Write("Qual valor que deseja depositar? R$ ");
                            valorDeposito = int.Parse(Console.ReadLine());
                            poupanca.Depositar(valorDeposito);
                        }
                        else if (escolha == 2)
                        {
                            Console.Write("Qual valor que deseja sacar? R$ ");
                            valorSaque = int.Parse(Console.ReadLine());

                            poupanca.Sacar(valorSaque);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }

                        contas.Add(poupanca);
                        break;
                    case 3:
                        Console.Write("\nSaldo inicial da conta: R$ ");
                        saldo = int.Parse(Console.ReadLine());
                        ContaSalario salario = new ContaSalario(saldo);
                        Console.Write("Deseja sacar (sim/nao): ");
                        String escolhaSaque = Console.ReadLine().ToUpper();


                        if (escolhaSaque.Equals("SIM"))
                        {
                            Console.Write("Qual valor que deseja sacar? R$ ");
                            valorSaque = int.Parse(Console.ReadLine());

                            salario.Sacar(valorSaque);
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                Console.Write("Deseja adicionar mais uma conta (sim/nao)? ");
                String continuar = Console.ReadLine().ToUpper();
                if (continuar.Equals("NAO") || continuar.Equals("NÃO")) break;

             }
            Console.WriteLine("-------------------");
              foreach (ContaBancaria conta in contas)
            {
                conta.ExibirSaldo();
            }
        }
    }
}
