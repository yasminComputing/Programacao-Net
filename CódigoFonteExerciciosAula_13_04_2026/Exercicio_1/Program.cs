namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoa = new List<Pessoa>();


            String nome, disciplina, cargo;
            int idade;
            

            int opcao;
            while (true)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("0-Sair");
                Console.WriteLine("1-Aluno");
                Console.WriteLine("2-Professor");
                Console.WriteLine("3-Funcionario");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("-------------");

                if (opcao == 0)
                {
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("INFORME O DADO DO ALUNO");
                        Console.Write("Informe seu nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Matrícula: ");
                        String matricula = Console.ReadLine();
                        Aluno aluno = new Aluno (nome, idade);
                        aluno.matricula = matricula; 
                        pessoa.Add(aluno);
                        break;

                    case 2:
                        Console.WriteLine("INFORME O DADO DO PROFESSOR");
                        Console.Write("Informe seu nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Disciplina: ");
                        disciplina = Console.ReadLine();

                        Professor professor = new Professor(nome, idade);
                        professor.disciplina = disciplina;
                        pessoa.Add(professor);
                        break;

                    case 3:
                        Console.WriteLine("INFORME DADO FUNCIONARIO");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Cargo: ");
                        cargo = Console.ReadLine();

                        Funcionario funcionario = new Funcionario(nome, idade);
                        funcionario.cargo = cargo;
                        pessoa.Add(funcionario);
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

            }
            foreach (Pessoa p in pessoa)
            {
                Console.WriteLine(p.ExibirTipo());
                p.Apresentar();
            }





        }
    }
}
