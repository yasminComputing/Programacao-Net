namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AparelhoSom> aparelho = new List<AparelhoSom>();

            Console.Write("Quantas vezes deseja auementar o volume dos aparelho? ");
            int quantidade = int.Parse(Console.ReadLine());

            aparelho.Add(new Radio());
            aparelho.Add(new HomeTheater());
           
            for(int i = 0; i< quantidade; i++)
            {
                foreach (AparelhoSom aparelhoSom in aparelho)
                {
                    aparelhoSom.AumentarVolume();
                }
            }
            
            }
        }
    }

