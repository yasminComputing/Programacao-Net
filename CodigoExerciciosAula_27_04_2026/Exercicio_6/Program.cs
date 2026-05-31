namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cidade> lista = new List<Cidade>();

            lista.Add(new Cidade("Santa Maria"));
            lista.Add(new Cidade("Agudo"));
            lista.Add(new Cidade("Porto Alegre"));

            try
            {
                Console.WriteLine("Informe um número (0 a 2) para exibir o nome da cidade: ");
                int indice = int.Parse(Console.ReadLine());

                 
                      Cidade cidade = lista[indice];
                      Console.WriteLine($"Cidade: {cidade.nome}");
                  
                

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ERRO: Número informado fora do índice");
            }
        }
    }

   
}
