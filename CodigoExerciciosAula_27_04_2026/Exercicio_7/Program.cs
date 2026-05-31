using System.Runtime.InteropServices;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                String texto = "123";
                if(int.TryParse(texto,out int numero))
                {
                    Console.WriteLine($"Conversão feita com sucesso\nNúmero: {numero}");
                }
                else
                {
                Console.WriteLine("Não foi possível converter");
                }
            
        }
    }
}
