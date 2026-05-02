namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe um número: ");
                decimal numero1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Informe outro número para divisão: ");
                decimal numero2 = decimal.Parse(Console.ReadLine());

                decimal divisao = numero1 / numero2;

                Console.WriteLine($"Resultado da divisão: {divisao}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não existe divisão por zero na matemática real");
            }
        }
    }
}
