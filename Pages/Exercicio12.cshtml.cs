using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1DR4DesWeb_2.Pages
{
    public class Exercicio12Model : PageModel
    {
        public static Action<Evento> OnEventoCriado;
        public Evento EventoCadastrado { get; set; }

        public void OnGet()
        {
        }        public void OnPost(string Titulo, DateTime Data, string Local)
        {
            EventoCadastrado = new Evento
            {
                Titulo = Titulo,
                Data = Data,
                Local = Local
            };
            OnEventoCriado?.Invoke(EventoCadastrado);
            Console.WriteLine($"Evento criado: {EventoCadastrado.Titulo}, {EventoCadastrado.Data}, {EventoCadastrado.Local}");
        }
    }

    public class Evento
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}
