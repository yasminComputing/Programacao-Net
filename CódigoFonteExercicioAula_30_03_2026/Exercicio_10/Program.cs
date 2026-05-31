namespace Exercicio_10
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            String opcao;
            Console.WriteLine("Digite o tipo de funcionário (vendedor/gerente):");
            string tipo = Console.ReadLine().ToLower();

            Console.WriteLine("Informe o nome do funcionário:");
            string nome = Console.ReadLine();

            if (tipo == "vendedor")
            {
                Console.WriteLine("Informe o salário base:");
                double salarioBase = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o total de vendas:");
                double vendas = double.Parse(Console.ReadLine());

                funcionarios.Add(new Vendedor(nome, salarioBase, vendas));
            }
            else if (tipo == "gerente")
            {
                Console.WriteLine("Informe o salário base:");
                double salarioBase = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor do bônus:");
                double bonus = double.Parse(Console.ReadLine());

                funcionarios.Add(new Gerente(nome, salarioBase, bonus));
            }
            else
            {
                Console.WriteLine("Tipo inválido!");
            }




            Console.WriteLine("\n--- Pagamentos ---");
            foreach (Funcionario f in funcionarios)
            {
                double pagamento = f.CalcularPagamento();
                Console.WriteLine($"{nome} receberá R$ {pagamento}");

                if (pagamento > 5000)
                {
                    Console.WriteLine("ALERTA DE ORÇAMENTO!");
                }
            }
        }
    }
}