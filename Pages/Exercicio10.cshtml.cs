using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1DR4DesWeb_2.Pages
{
    public class Exercicio10Model : PageModel
    {
        public Produto ProdutoCadastrado { get; set; }
        public void OnGet()
        {
        }
        public void OnPost(string Nome, decimal Preco)
        {
            ProdutoCadastrado = new Produto
            {
                Nome = Nome,
                Preco = Preco
            };
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
