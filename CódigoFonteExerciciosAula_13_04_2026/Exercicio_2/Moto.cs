using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    public  class Moto : Veiculo
    {
      
        public Moto(String marca,String modelo) : base(marca, modelo) { }
        public int cilindrada { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo a {marca} {modelo} com {cilindrada} cilindradas");
        }
        public override double CalcularConsumo()
        {
            return 1000.0/ cilindrada;
        }
    }
}
