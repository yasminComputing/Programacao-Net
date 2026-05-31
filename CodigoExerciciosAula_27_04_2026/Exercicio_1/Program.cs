namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Número informado: {numero}");
            }catch (Exception e)
            {
                Console.WriteLine("Formato digitado está incorreto!Tente Novamente!");
    
            }
        }
    }
}
