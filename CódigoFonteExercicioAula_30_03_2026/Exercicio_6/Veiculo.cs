using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Exercicio_6
{
    public abstract class Veiculo
    {
        public abstract double CalcularPedagio();
    }
   
    public class Carro : Veiculo
    {
        public override double CalcularPedagio()
        {
            return 10.0;
        }
    }
    public class Caminhao : Veiculo
    {
        public int Eixos { get; set; }
        public Caminhao(int eixos)
        {
            Eixos = eixos;
        }
        public override double CalcularPedagio()
        {
            return 10.0 * Eixos;
        }
    }
    }  
