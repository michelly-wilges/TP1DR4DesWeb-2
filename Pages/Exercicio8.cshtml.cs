using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1DR4DesWeb_2.Pages
{
    public class ProdutosModel : PageModel
    {
        public List<(String Nome, decimal Preco)> Produtos { get; set; }
                public void OnGet()
        {
            Produtos = new List<(String, decimal)>
            {
                ("Caderno", 49.99m),
                ("Estojo", 20.49m),
                ("Caneta", 3.75m)
            };
        }
    }
}