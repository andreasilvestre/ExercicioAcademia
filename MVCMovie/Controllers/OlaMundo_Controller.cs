using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovie.Controllers
{
    public class OlaMundo_Controller : Controller
    {
        //public string Index()
        //{
        //    return "Minha ação padrão";
        //}

        public IActionResult Index()
        {
            return View();
        }

        public string BemVindo(string nome, int vezes = 1)
        {
            return HtmlEncoder.Default.Encode($"oi{ nome}, vezes: { vezes}");
            //return "Bem vindo ao meu método de boas vindas do meu controller";
        }
        public string Teste()
        {
            return "Aqui mostra a relação rota x método";
        }
    }

}
