namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe uma mensagem que deseja enviar: "); ;
            String mensagem = Console.ReadLine();

            Console.WriteLine("Qual meio de comunicação vai ser enviado? (email ou sms): ");
            String opcao = Console.ReadLine().ToUpper();

            Mensagem mensagemEscolhida;

            if (opcao.Equals("EMAIL"))
            {
                mensagemEscolhida = new Email(mensagem);

            }
            else if (opcao.Equals("SMS"))
            {
                mensagemEscolhida = new SMS(mensagem);
            }
            else{
                Console.WriteLine("Opção inválida!");
                return;
            }
            mensagemEscolhida.Enviar();




        }
    }
}
