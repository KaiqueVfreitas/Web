using Microsoft.AspNetCore.Mvc;
using ProjetoAps3.Models;
using System.Diagnostics;

namespace ProjetoAps3.Controllers
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

       
        public IActionResult Perucas(IFormCollection frm)
        {

            double v1, v2, v3, v4, soma, media;
            v1 = Convert.ToDouble(frm["valor1"]);
            v2 = Convert.ToDouble(frm["valor2"]);
            v3 = Convert.ToDouble(frm["valor3"]);
            v4 = Convert.ToDouble(frm["valor4"]);


            soma = v1 + v2 + v3 + v4;
            media = soma / 4;

            ViewBag.soma = "A soma é: " + soma;
            ViewBag.media = "A media é " + media;

            if (media >= 300 && media <= 499)
            {
                ViewBag.Res = "Peruca atingida";
            }
            else if (media >= 500)
            {
                ViewBag.Res = "Peruca superada";
            }
            else
            {
                ViewBag.Res = "Peruca não atingida";
            }
            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
        }
       
}
