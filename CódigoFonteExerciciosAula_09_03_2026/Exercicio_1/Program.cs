namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Matrícula: ");
            aluno.matricula = Console.ReadLine();

            Console.Write("Nota 1: ");
            aluno.nota1 = float.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            aluno.nota2 = float.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            aluno.nota3 = float.Parse(Console.ReadLine());

           

            Console.WriteLine("Dados do aluno:");

            Console.WriteLine($"Nome: {aluno.nome}\nMatrícula: {aluno.matricula}\nNota 1: {aluno.nota1}\nNota 2: {aluno.nota2}\nNota 3: {aluno.nota3}");

            if (aluno.calcularNota() >= 6) {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }


        }
    }
}
