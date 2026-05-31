using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Runtime.CompilerServices;

namespace PainelSocioTorcedores.Pages
{
    public class SocioTorcedorModel : PageModel
    {


        public List<SocioTorcedor> Socios { get; set; }
        public void OnGet()
        {
          
            
                Socios = new List<SocioTorcedor> { 
            
                new SocioTorcedor {Nome = "Flávio",Categoria = "Ouro",Idade = 30,Mensalidade = 125.00m},
                new SocioTorcedor{Nome = "Ana",Categoria = "Bronze",Idade = -25,Mensalidade = 90.00m},
                new SocioTorcedor{Nome = "Luiz",Categoria = "Bronze",Idade = 45,Mensalidade = 29.00m},
                //Na execução a Categoria AAAA será trocado pela categoria de Bronze
                new SocioTorcedor{Nome = "Carlos",Categoria = "AAAA",Idade = 18,Mensalidade = 200.00m },
                new SocioTorcedor{Nome = "Guilherme",Categoria = "Prata",Idade = 18,Mensalidade = 200.00m }
            };
            
            
        }
    }
    public class SocioTorcedor
    {
        public string Nome { get; set; }
        private string _categoria;
        private int _idade;
        private decimal _mensalidade;

        public string Categoria
        {
            get { return _categoria; }
            set
            {
                if (value == "Ouro" || value == "Prata" || value == "Bronze")
                {
                    _categoria = value;
                }
                else
                {
                    _categoria = "Bronze";

                }
            }

        }
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    _idade = 0;
                }
                else
                {
                    _idade = value;

                }
            }
        }
        public decimal Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                if (value < 45.00m)
                {
                    _mensalidade = 45.00m;
                }
                _mensalidade = value;
            }
        }
    }

}
