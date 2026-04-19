using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Security.Cryptography;
using System.Text;

namespace Exercicio_2
{
    public  class Carro : Veiculo
    {
        public int portas { get; set; } = 2;
        public double km { get; set; }
        public double litros { get; set; }

        public Carro(String marca,String modelo) : base(marca, modelo) { }

        

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {marca} {modelo} com {portas} portas");
        }
        public override double CalcularConsumo()
        {
            return km / litros;
        }
    }
}
