using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using terceiraAulaCdrCidade.Models;

namespace terceiraAulaCdrCidade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(IFormCollection form)
        {
            double v1, v2, v3, v4, soma, Media;
            v1 = double.Parse(form["valor1"]);
            v2 = double.Parse(form["valor2"]);
            v3 = double.Parse(form["valor3"]);
            v4 = double.Parse(form["valor4"]);

            soma = v1 + v2 + v3 + v4;
            Media = soma/4;

            ViewBag.soma = "A soma é: " + soma;
            ViewBag.media = "A média é: " + Media;
            
            if (Media >= 300 && Media <= 499)
            {
                ViewBag.Res = "Peruca atingida";
            }
            else if (Media >= 500)
            {
                ViewBag.Res = "Peruca superada";
            }
            else
            {
                ViewBag.Res = "Peruca não atinida";
            }
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
