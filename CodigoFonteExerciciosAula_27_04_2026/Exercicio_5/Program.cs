using System.Runtime.InteropServices;

namespace Exercicio_5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                VerificarIdade(idade);
                Console.WriteLine("Idade informada está válida");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Erro:{e.Message} ");
            }
        }
        static void VerificarIdade(int idade)
        {
            if (idade < 0 || idade > 150)
            {
                throw new ArgumentOutOfRangeException(
                                  "idade",
                                  "A idade deve estar entre 0 e 150.");
            
         }
        }
    }
}
