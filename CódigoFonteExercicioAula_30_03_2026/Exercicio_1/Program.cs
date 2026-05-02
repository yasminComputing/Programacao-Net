using static Exercicio_1.Animal;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animais = new List<Animal>()
            {
                new Cachorro("Thor"),
                new Gato("Sol"),
                new Cachorro( "Rex"),
                new Gato("Luna"),
                new Cachorro("Zeus"),
                new Gato("Tom"),
            };
           
            foreach (Animal animal in animais)
            {
                animal.EmitirSom();
            }
           
                
            


        }
    }
}
