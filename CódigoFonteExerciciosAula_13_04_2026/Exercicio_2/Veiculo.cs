using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    public abstract class Veiculo
    {
        public String marca { get; set; }
        public String modelo { get; set; }
        public Veiculo(String marca,String modelo)
        {
            this.marca = marca;
            this.modelo = modelo; 
        }
        public abstract void Dirigir();

        public abstract double CalcularConsumo();        
    }
    
}
