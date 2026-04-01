using System;

namespace Exercicio_4
{
    public abstract class Mensagem
    {
        public string mensagem { get; set; }

        public Mensagem() { }

        public Mensagem(string mensagem)
        {
            this.mensagem = mensagem;
        }

        public abstract void Enviar();
    }

    public class Email : Mensagem
    {
        public Email(string mensagem) : base(mensagem) { }

        public override void Enviar()
        {
            Console.WriteLine($"Mensagem enviada por EMAIL....{mensagem}");
        }
    }

    public class SMS : Mensagem
    {
        public SMS(string mensagem) : base(mensagem) { }

        public override void Enviar()
        {
            Console.WriteLine($"Mensagem enviada por SMS....{mensagem}");
        }
    }
}