using Microsoft.AspNetCore.Mvc;

namespace MVCMovie2
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "Minha ação padrão";
        }

        public string Welcome()
        {
            return "Bem vindo ao meu método de boas vindas do meu controller";
        }
    }
}
