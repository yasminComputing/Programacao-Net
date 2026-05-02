namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String valor = "123";
                /*
                 int conversao = (int)valor;
                * O C# não saber converter automaticamente texto
                * em número usando cast causando um InvalidCastException.
                * Por isso é usado  int conversao = int.Parse(valor);
                */

                int conversao = (int)(object)valor;
                Console.WriteLine("Conversão feita....");

            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"Conversão inválida: {e.Message}");
            }
        }
    }
}
