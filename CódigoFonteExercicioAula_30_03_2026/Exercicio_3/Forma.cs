using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public abstract class Forma
    {
        public float Base { get; set; }
        public float altura { get; set;}
        public float lado { get; set;}
        public abstract float CalcularArea();
    }
    public class  Quadrado : Forma { }
    {
       public Quadrado (float lado){
        this.lado = lado;
    }

    public override float CalcularArea(){
        return lado * lado;
    }
}
}
