using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    public abstract class AparelhoSom{
        public int volume { get;protected set; } = 0;
        public abstract void AumentarVolume();
        
    }
    public class  Radio: AparelhoSom
    {
        public override void AumentarVolume()
        {
            volume += 1;
            Console.WriteLine($"Volume do rádio aumentado para: {volume}");
        }
    }
    public class HomeTheater : AparelhoSom
    {
        public override void AumentarVolume()
        {
            volume += 5;
            Console.WriteLine($"Volume do homeTheater aumentado para: {volume}");
        }
    }


}
