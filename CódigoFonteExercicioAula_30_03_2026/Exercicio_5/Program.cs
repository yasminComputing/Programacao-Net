using Exercicio_5;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o tipo de conta (corrente/poupanca):");
        string tipoConta = Console.ReadLine().ToLower();

        Console.WriteLine("Informe o saldo inicial da conta:");
        double saldoInicial = Double.Parse(Console.ReadLine());

        Conta conta;

        if (tipoConta == "corrente")
        {
            conta = new ContaCorrente(saldoInicial);
        }
        else if (tipoConta == "poupanca")
        {
            conta = new ContaPoupanca(saldoInicial);
        }
        else
        {
            Console.WriteLine("Tipo de conta inválido!");
            return;
        }

        Console.WriteLine("Informe o valor que deseja sacar:");
        double valorSaque = Convert.ToDouble(Console.ReadLine());

        conta.Sacar(valorSaque);

        Console.WriteLine($"Saldo final: R$ {conta.ConsultarSaldo()}");
    }
}
