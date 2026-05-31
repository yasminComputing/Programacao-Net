namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe um valor para saque: R$ ");
                decimal valor = decimal.Parse(Console.ReadLine());
                ContaBancaria conta = new ContaBancaria();
                conta.Sacar(valor);
            }catch (SaldoInsuficienteException e)
            {
                Console.WriteLine($"ERRO:{e.Message}");
            }
        }
    }
}
