namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Conexão Aberta");

                int a = 0;
                int b = a + 1;
                int c = b / a;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocore um erro durante o processo");
            }
            finally
            {
                Console.WriteLine("Conexão Fechada");
            }
        }
    }
}
