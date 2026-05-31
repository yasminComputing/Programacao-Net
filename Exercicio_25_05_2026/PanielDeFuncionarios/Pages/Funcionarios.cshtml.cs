using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PanielDeFuncionarios.Pages
{
    public class FuncionariosModel : PageModel
    {
        public List<Funcionario> Funcionarios{ get; set; }
        public void OnGet()
        {
            Funcionarios = new List<Funcionario>
            {
                new Funcionario {Nome = "João",Cargo = "Desenvolvedor",Salario = 5000m},
                new Funcionario {Nome = "Maria",Cargo = "Gerente",Salario = 8500m},
                new Funcionario {Nome = "Pedro",Cargo = "Vendedor",Salario = 2000m},
                new Funcionario{Nome = "Luiz",Cargo = "Auxiliar Adminstrativo",Salario = 1500m},

            };
        }
    }
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
    }
}

